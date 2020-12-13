using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Lumin_Shows.FormHelpers
{
    internal static class FormHelpers
    {
   
        public static bool checkComboBoxBindingVal(ComboBox cmb)
        {
            return cmb.SelectedValue == DBNull.Value;
        }

        public static bool checkIfTextEmpty(string val)
        {
            return String.IsNullOrEmpty(val);
        }

        public static void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                Console.WriteLine("Clearing Control " + ctl.Name + DateTime.Now);
                switch (ctl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case RichTextBox txb:
                        txb.Clear();
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case ComboBox cmb:
                        cmb.SelectedIndex = -1;
                        break;
                    case RadioButton rdBtn:
                        rdBtn.Checked = false;
                        break;

                    case GroupBox gB:
                        ClearControls(gB.Controls);
                        break;
                }
            }
        }

        public static void FillListControl(ListControl control, string displayMember,
            string valueMember, DataTable dt, bool insertBlank = false, string defaultText = "")
        {
            if (insertBlank)
            {
                DataRow row = dt.NewRow();
                row[valueMember] = DBNull.Value;
                row[displayMember] = defaultText;
                dt.Rows.InsertAt(row, 0);
            }

            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = dt;
        }

        public static void SetToolStripMsg(string msg, ToolStripStatusLabel toolS, Color color)
        {
            toolS.ForeColor = color;
            toolS.Text = msg;
        }

        public static void SetStatusToolTipMsg(string msg,ToolTip toolTip, Control ctrl)
        {
            toolTip.SetToolTip(ctrl, msg);
        }
    }
}
