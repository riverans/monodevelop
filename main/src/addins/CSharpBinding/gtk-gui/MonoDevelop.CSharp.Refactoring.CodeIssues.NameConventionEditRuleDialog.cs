
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.CSharp.Refactoring.CodeIssues
{
	internal partial class NameConventionEditRuleDialog
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label4;
		private global::Gtk.Entry entryRuleName;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Table table1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewEntities;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView treeviewAccessibility;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Table table2;
		private global::Gtk.Entry entryPrefix;
		private global::Gtk.Entry entryPrefixAllowed;
		private global::Gtk.Entry entrySuffix;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Label label8;
		private global::Gtk.ComboBox styleComboBox;
		private global::Gtk.VBox vbox1;
		private global::Gtk.CheckButton checkbuttonStatic;
		private global::Gtk.CheckButton checkbuttonInstanceMembers;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Label label9;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.CSharp.Refactoring.CodeIssues.NameConventionEditRuleDialog
			this.WidthRequest = 640;
			this.HeightRequest = 480;
			this.Name = "MonoDevelop.CSharp.Refactoring.CodeIssues.NameConventionEditRuleDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Edit Naming Rule");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Resizable = false;
			this.DestroyWithParent = true;
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child MonoDevelop.CSharp.Refactoring.CodeIssues.NameConventionEditRuleDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("_Rule:");
			this.label4.UseUnderline = true;
			this.hbox3.Add (this.label4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label4]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entryRuleName = new global::Gtk.Entry ();
			this.entryRuleName.CanFocus = true;
			this.entryRuleName.Name = "entryRuleName";
			this.entryRuleName.IsEditable = true;
			this.entryRuleName.InvisibleChar = '●';
			this.hbox3.Add (this.entryRuleName);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entryRuleName]));
			w3.Position = 1;
			this.vbox3.Add (this.hbox3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewEntities = new global::Gtk.TreeView ();
			this.treeviewEntities.WidthRequest = 0;
			this.treeviewEntities.CanFocus = true;
			this.treeviewEntities.Name = "treeviewEntities";
			this.treeviewEntities.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.treeviewEntities);
			this.table1.Add (this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkScrolledWindow]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeviewAccessibility = new global::Gtk.TreeView ();
			this.treeviewAccessibility.CanFocus = true;
			this.treeviewAccessibility.Name = "treeviewAccessibility";
			this.treeviewAccessibility.HeadersVisible = false;
			this.GtkScrolledWindow1.Add (this.treeviewAccessibility);
			this.table1.Add (this.GtkScrolledWindow1);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkScrolledWindow1]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("_Affected entities:");
			this.label5.UseUnderline = true;
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("_Accessibility:");
			this.label6.UseUnderline = true;
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.table2 = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.entryPrefix = new global::Gtk.Entry ();
			this.entryPrefix.CanFocus = true;
			this.entryPrefix.Name = "entryPrefix";
			this.entryPrefix.IsEditable = true;
			this.entryPrefix.InvisibleChar = '●';
			this.table2.Add (this.entryPrefix);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryPrefix]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryPrefixAllowed = new global::Gtk.Entry ();
			this.entryPrefixAllowed.CanFocus = true;
			this.entryPrefixAllowed.Name = "entryPrefixAllowed";
			this.entryPrefixAllowed.IsEditable = true;
			this.entryPrefixAllowed.InvisibleChar = '●';
			this.table2.Add (this.entryPrefixAllowed);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryPrefixAllowed]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entrySuffix = new global::Gtk.Entry ();
			this.entrySuffix.CanFocus = true;
			this.entrySuffix.Name = "entrySuffix";
			this.entrySuffix.IsEditable = true;
			this.entrySuffix.InvisibleChar = '●';
			this.table2.Add (this.entrySuffix);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.entrySuffix]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Prefix:");
			this.table2.Add (this.label1);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.label1]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Style:");
			this.table2.Add (this.label2);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2 [this.label2]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Suffix:");
			this.table2.Add (this.label3);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2 [this.label3]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Optional Prefixes:");
			this.table2.Add (this.label8);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.label8]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.styleComboBox = global::Gtk.ComboBox.NewText ();
			this.styleComboBox.Name = "styleComboBox";
			this.table2.Add (this.styleComboBox);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.styleComboBox]));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.checkbuttonStatic = new global::Gtk.CheckButton ();
			this.checkbuttonStatic.CanFocus = true;
			this.checkbuttonStatic.Name = "checkbuttonStatic";
			this.checkbuttonStatic.Label = global::Mono.Unix.Catalog.GetString ("_Static member and types");
			this.checkbuttonStatic.Active = true;
			this.checkbuttonStatic.DrawIndicator = true;
			this.checkbuttonStatic.UseUnderline = true;
			this.vbox1.Add (this.checkbuttonStatic);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.checkbuttonStatic]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.checkbuttonInstanceMembers = new global::Gtk.CheckButton ();
			this.checkbuttonInstanceMembers.CanFocus = true;
			this.checkbuttonInstanceMembers.Name = "checkbuttonInstanceMembers";
			this.checkbuttonInstanceMembers.Label = global::Mono.Unix.Catalog.GetString ("_Instance members and locals");
			this.checkbuttonInstanceMembers.Active = true;
			this.checkbuttonInstanceMembers.DrawIndicator = true;
			this.checkbuttonInstanceMembers.UseUnderline = true;
			this.vbox1.Add (this.checkbuttonInstanceMembers);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.checkbuttonInstanceMembers]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.table2.Add (this.vbox1);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbox1]));
			w21.TopAttach = ((uint)(4));
			w21.BottomAttach = ((uint)(5));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Static/Non Static");
			this.vbox5.Add (this.label9);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label9]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			this.table2.Add (this.vbox5);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbox5]));
			w23.TopAttach = ((uint)(4));
			w23.BottomAttach = ((uint)(5));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add (this.table2);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.table2]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(4));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(0));
			this.hbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table1]));
			w25.Position = 0;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w26.Position = 1;
			w1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox3]));
			w27.Position = 0;
			w27.Padding = ((uint)(6));
			// Internal child MonoDevelop.CSharp.Refactoring.CodeIssues.NameConventionEditRuleDialog.ActionArea
			global::Gtk.HButtonBox w28 = this.ActionArea;
			w28.Name = "dialog1_ActionArea";
			w28.Spacing = 10;
			w28.BorderWidth = ((uint)(5));
			w28.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w29 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w28 [this.buttonCancel]));
			w29.Expand = false;
			w29.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w30 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w28 [this.buttonOk]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 804;
			this.DefaultHeight = 508;
			this.Show ();
		}
	}
}
