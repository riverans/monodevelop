//
// ProjectTemplateNuGetPackageInstaller.cs
//
// Author:
//       Matt Ward <matt.ward@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using MonoDevelop.Ide.Templates;
using MonoDevelop.Projects;
using System.Collections.Generic;
using ICSharpCode.PackageManagement;
using MonoDevelop.Ide;
using NuGet;
using MonoDevelop.Core;
using MonoDevelop.Ide.Gui;
using System.Linq;
using MonoDevelop.Core.ProgressMonitoring;

namespace MonoDevelop.PackageManagement
{
	public class ProjectTemplateNuGetPackageInstaller : ProjectTemplatePackageInstaller
	{
		IPackageManagementSolution packageManagementSolution;
		IPackageRepositoryCache packageRepositoryCache;
		IPackageManagementEvents packageManagementEvents;

		public ProjectTemplateNuGetPackageInstaller ()
			: this(
				PackageManagementServices.Solution,
				PackageManagementServices.PackageManagementEvents,
				PackageManagementServices.ProjectTemplatePackageRepositoryCache)
		{
		}

		public ProjectTemplateNuGetPackageInstaller (
			IPackageManagementSolution solution,
			IPackageManagementEvents packageManagementEvents,
			IPackageRepositoryCache packageRepositoryCache)
		{
			this.packageManagementSolution = solution;
			this.packageManagementEvents = packageManagementEvents;
			this.packageRepositoryCache = packageRepositoryCache;
		}

		public override void Run (IList<PackageReferencesForCreatedProject> packageReferencesForCreatedProjects)
		{
			List<InstallPackageAction> installPackageActions = CreateInstallPackageActions (packageReferencesForCreatedProjects);
			DispatchService.BackgroundDispatch (() => InstallPackagesWithProgressMonitor (installPackageActions));
		}

		List<InstallPackageAction> CreateInstallPackageActions (IList<PackageReferencesForCreatedProject> packageReferencesForCreatedProjects)
		{
			var installPackageActions = new List<InstallPackageAction> ();

			Solution solution = IdeApp.ProjectOperations.CurrentSelectedSolution;
			foreach (PackageReferencesForCreatedProject packageReferences in packageReferencesForCreatedProjects) {
				var project = solution.GetAllProjects ().First (p => p.Name == packageReferences.ProjectName) as DotNetProject;
				if (project != null) {
					installPackageActions.AddRange (CreateInstallPackageActions (project, packageReferences));
				}
			}

			return installPackageActions;
		}

		void InstallPackagesWithProgressMonitor (IList<InstallPackageAction> installPackageActions)
		{
			using (IProgressMonitor monitor = CreateProgressMonitor ()) {
				using (var eventMonitor = new PackageManagementEventsMonitor (monitor, packageManagementEvents)) {
					try {
						InstallPackages (installPackageActions);
					} catch (Exception ex) {
						monitor.Log.WriteLine (ex.Message);
						monitor.ReportError (GettextCatalog.GetString ("Packages could not be installed."), null);
					}
				}
			}
		}

		void InstallPackages (IList<InstallPackageAction> installPackageActions)
		{
			foreach (InstallPackageAction action in installPackageActions) {
				action.Execute ();
			}
		}

		IProgressMonitor CreateProgressMonitor ()
		{
			IProgressMonitor consoleMonitor = IdeApp.Workbench.ProgressMonitors.GetOutputProgressMonitor (
				"PackageConsole",
				GettextCatalog.GetString ("Package Console"),
				Stock.Console,
				false,
				true);

			Pad pad = IdeApp.Workbench.ProgressMonitors.GetPadForMonitor (consoleMonitor);

			IProgressMonitor statusMonitor = IdeApp.Workbench.ProgressMonitors.GetStatusProgressMonitor (
				GettextCatalog.GetString ("Installing packages..."),
				Stock.StatusSolutionOperation,
				false,
				false,
				false,
				pad);

			var monitor = new AggregatedProgressMonitor (consoleMonitor);
			monitor.AddSlaveMonitor (statusMonitor);
			return monitor;
		}

		IEnumerable<InstallPackageAction> CreateInstallPackageActions (DotNetProject dotNetProject, PackageReferencesForCreatedProject projectPackageReferences)
		{
			IPackageManagementProject project = CreatePackageManagementProject (dotNetProject);
			foreach (ProjectTemplatePackageReference packageReference in projectPackageReferences.PackageReferences) {
				InstallPackageAction action = project.CreateInstallPackageAction ();
				action.PackageId = packageReference.Id;
				action.PackageVersion = new SemanticVersion (packageReference.Version);

				yield return action;
			}
		}

		IPackageManagementProject CreatePackageManagementProject (DotNetProject dotNetProject)
		{
			return packageManagementSolution.GetProject (packageRepositoryCache.CreateAggregateRepository (), dotNetProject);
		}
	}
}

