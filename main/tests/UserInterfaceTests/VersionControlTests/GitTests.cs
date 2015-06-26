﻿//
// GitTests.cs
//
// Author:
//       Manish Sinha <manish.sinha@xamarin.com>
//
// Copyright (c) 2015 Xamarin Inc.
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
using MonoDevelop.Ide.Commands;
using NUnit.Framework;

namespace UserInterfaceTests
{
	[TestFixture]
	[Category ("Git")]
	public class GitTests : VCSBase
	{
		[Test]
		[TestCase ("git@github.com:mono/jurassic.git", TestName = "TestGitSSHClone")]
		[TestCase ("https://github.com/mono/jurassic.git", TestName = "TestGitHTTPSClone")]
		public void TestGitClone (string url)
		{
			TestClone (url);
			Ide.WaitForSolutionCheckedOut ();
		}

		[Test]
		public void TestCommit ()
		{
			var templateOptions = new TemplateSelectionOptions {
				CategoryRoot = OtherCategoryRoot,
				Category = ".NET",
				TemplateKindRoot = GeneralKindRoot,
				TemplateKind = "Console Project"
			};
			CreateProject (templateOptions,
				new ProjectDetails (templateOptions),
				new GitOptions { UseGit = true, UseGitIgnore = true});
			
			Session.WaitForElement (IdeQuery.TextArea);
			TestCommit ("First commit");
		}

		[Test]
		public void TestNoChangesStashOperation ()
		{
			var templateOptions = new TemplateSelectionOptions {
				CategoryRoot = OtherCategoryRoot,
				Category = ".NET",
				TemplateKindRoot = GeneralKindRoot,
				TemplateKind = "Console Project"
			};
			CreateProject (templateOptions,
				new ProjectDetails (templateOptions),
				new GitOptions { UseGit = true, UseGitIgnore = true});
			
			Session.WaitForElement (IdeQuery.TextArea);
			TestCommit ("First commit");
			Session.ExecuteCommand (FileCommands.CloseAllFiles);
			Assert.Throws <TimeoutException> (() => TestGitStash ("No changes stash attempt"));
			Ide.WaitForStatusMessage (new [] {"No changes were available to stash"}, 20);
		}

		[Test]
		public void TestStashWithoutHeadCommit ()
		{
			var templateOptions = new TemplateSelectionOptions {
				CategoryRoot = OtherCategoryRoot,
				Category = ".NET",
				TemplateKindRoot = GeneralKindRoot,
				TemplateKind = "Console Project"
			};
			CreateProject (templateOptions,
				new ProjectDetails (templateOptions),
				new GitOptions { UseGit = true, UseGitIgnore = true});
			
			Session.WaitForElement (IdeQuery.TextArea);
			Assert.Throws <TimeoutException> (() => TestGitStash ("Stash without head commit"));
			TakeScreenShot ("Stash-Window-Doesnt-Show");
		}

		[Test]
		public void TestStashAndUnstashSuccessful ()
		{
			var templateOptions = new TemplateSelectionOptions {
				CategoryRoot = OtherCategoryRoot,
				Category = ".NET",
				TemplateKindRoot = GeneralKindRoot,
				TemplateKind = "Console Project"
			};
			CreateProject (templateOptions, 
				new ProjectDetails (templateOptions),
				new GitOptions { UseGit = true, UseGitIgnore = true });
			
			Session.WaitForElement (IdeQuery.TextArea);
			TestCommit ("First commit");

			Session.ExecuteCommand (FileCommands.CloseFile);
			Session.WaitForElement (IdeQuery.TextArea);

			Session.ExecuteCommand (TextEditorCommands.InsertNewLine);
			TakeScreenShot ("Inserted-Newline-Marked-Dirty");
			Session.ExecuteCommand (FileCommands.SaveAll);
			TakeScreenShot ("Inserted-Newline-SaveAll-Called");

			TestGitStash ("Entered new blank line");

			Session.WaitForElement (IdeQuery.TextArea);
			TakeScreenShot ("After-Stash");

			TestGitUnstash ();
			TakeScreenShot ("Untash-Successful");
		}
	}
}

