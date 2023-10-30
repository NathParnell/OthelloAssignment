using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace MyDialogs
{
    class My_Dialogs
    {
        public static string InputBox(string promptText)//Constructor for inputbox with title and this makes it all equal to the tird one
        {
            string default_value = "";

            return InputBox("", promptText, ref default_value);
        }
        public static string InputBox(string title, string promptText)
        {
            string default_value = "";

            return InputBox(title, promptText, ref default_value);
        }
        public static string InputBox(string title, string promptText, ref string value)//mydialog.InputBox(....
        {
            //Creating all the components of the input box
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            //these make the passed parameters the values in the form
            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            //dimensions and positioning of the components
            label.SetBounds(9, 12, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 30);
            buttonCancel.SetBounds(309, 72, 75, 30);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            //gives the value which is returned a random name that hopefully nobody will ever use.
           if (form.ShowDialog() == DialogResult.Cancel)
                textBox.Text = "asdfsasds12321223aaddvfb";



            return textBox.Text;
        }
    }
}
