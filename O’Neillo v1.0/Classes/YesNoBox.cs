using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace O_Neillo_v1._0.Classes
{
    class YesNoBox
    {
        public static bool InputBox(string promptText)//Constructor for inputbox with title and this makes it all equal to the tird one
        {
            string default_value = "";

            return InputBox("", promptText, ref default_value);
        }
        public static bool InputBox(string title, string promptText)
        {
            string default_value = "";

            return InputBox(title, promptText, ref default_value);
        }
        public static bool InputBox(string title, string promptText, ref string value)//mydialog.InputBox(....
        {
            //Creating all the components of the input box
            Form form = new Form();
            Label label = new Label();
            Button ButtonYes = new Button();
            Button ButtonNo = new Button();

            //these make the passed parameters the values in the form
            form.Text = title;
            label.Text = promptText;

            ButtonYes.Text = "Yes";
            ButtonNo.Text = "No";
            ButtonYes.DialogResult = DialogResult.Yes;
            ButtonNo.DialogResult = DialogResult.No;

            //dimensions and positioning of the components
            label.SetBounds(9, 12, 372, 13);
            ButtonYes.SetBounds(228, 72, 75, 30);
            ButtonNo.SetBounds(309, 72, 75, 30);

            label.AutoSize = true;
            ButtonYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, ButtonYes, ButtonNo });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = ButtonYes;
            form.CancelButton = ButtonNo;

            if (form.ShowDialog() == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
