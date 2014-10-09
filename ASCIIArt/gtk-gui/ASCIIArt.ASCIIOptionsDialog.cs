
// This file has been generated by the GUI designer. Do not modify.
namespace ASCIIArt
{
	public partial class ASCIIOptionsDialog
	{
		private global::Gtk.Label label1;
		private global::Gtk.RadioButton radioButtonAscii;
		private global::Gtk.RadioButton radioButtonBlocks;
		private global::Gtk.HBox hbox3;
		private global::Gtk.RadioButton radiobutton3;
		private global::Gtk.Entry entryFieldChars;
		private global::Gtk.Label label2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label3;
		private global::Gtk.SpinButton spinButtonW;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label4;
		private global::Gtk.SpinButton spinButtonH;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ASCIIArt.ASCIIOptionsDialog
			this.Name = "ASCIIArt.ASCIIOptionsDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child ASCIIArt.ASCIIOptionsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Preset characters");
			w1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.radioButtonAscii = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString (" .,;!vlLFE$"));
			this.radioButtonAscii.CanFocus = true;
			this.radioButtonAscii.Name = "radioButtonAscii";
			this.radioButtonAscii.DrawIndicator = true;
			this.radioButtonAscii.UseUnderline = true;
			this.radioButtonAscii.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			w1.Add (this.radioButtonAscii);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(w1 [this.radioButtonAscii]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.radioButtonBlocks = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString (" ░▒▓█"));
			this.radioButtonBlocks.CanFocus = true;
			this.radioButtonBlocks.Name = "radioButtonBlocks";
			this.radioButtonBlocks.DrawIndicator = true;
			this.radioButtonBlocks.UseUnderline = true;
			this.radioButtonBlocks.Group = this.radioButtonAscii.Group;
			w1.Add (this.radioButtonBlocks);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.radioButtonBlocks]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.radiobutton3 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Custom (Cannot be opened in Pinta again)"));
			this.radiobutton3.CanFocus = true;
			this.radiobutton3.Name = "radiobutton3";
			this.radiobutton3.DrawIndicator = true;
			this.radiobutton3.UseUnderline = true;
			this.radiobutton3.Group = this.radioButtonAscii.Group;
			this.hbox3.Add (this.radiobutton3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.radiobutton3]));
			w5.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entryFieldChars = new global::Gtk.Entry ();
			this.entryFieldChars.CanFocus = true;
			this.entryFieldChars.Name = "entryFieldChars";
			this.entryFieldChars.IsEditable = true;
			this.entryFieldChars.InvisibleChar = '•';
			this.hbox3.Add (this.entryFieldChars);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entryFieldChars]));
			w6.Position = 2;
			w1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox3]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			w1.Add (this.label2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(w1 [this.label2]));
			w8.Position = 4;
			w8.Expand = false;
			w8.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Horisontal cell size");
			this.hbox1.Add (this.label3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label3]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.spinButtonW = new global::Gtk.SpinButton (0, 1000, 1);
			this.spinButtonW.CanFocus = true;
			this.spinButtonW.Name = "spinButtonW";
			this.spinButtonW.Adjustment.PageIncrement = 10;
			this.spinButtonW.ClimbRate = 1;
			this.spinButtonW.Numeric = true;
			this.hbox1.Add (this.spinButtonW);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.spinButtonW]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w11.Position = 5;
			w11.Expand = false;
			w11.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Vertical cell size");
			this.hbox2.Add (this.label4);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label4]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.spinButtonH = new global::Gtk.SpinButton (0, 1000, 1);
			this.spinButtonH.CanFocus = true;
			this.spinButtonH.Name = "spinButtonH";
			this.spinButtonH.Adjustment.PageIncrement = 10;
			this.spinButtonH.ClimbRate = 1;
			this.spinButtonH.Numeric = true;
			this.hbox2.Add (this.spinButtonH);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.spinButtonH]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			w1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox2]));
			w14.Position = 6;
			w14.Expand = false;
			w14.Fill = false;
			// Internal child ASCIIArt.ASCIIOptionsDialog.ActionArea
			global::Gtk.HButtonBox w15 = this.ActionArea;
			w15.Name = "dialog1_ActionArea";
			w15.Spacing = 10;
			w15.BorderWidth = ((uint)(5));
			w15.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15 [this.buttonCancel]));
			w16.Expand = false;
			w16.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15 [this.buttonOk]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 461;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}