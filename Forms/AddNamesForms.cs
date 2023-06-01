using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox.Forms
{
    public partial class AddNamesForms : Form
    {
        public AddNamesForms()
        {
            InitializeComponent();
        }

        private void Ok_Bt_Click(object sender, EventArgs e)
        {
            if (Name_Dt.Text.Trim() != "" && Regex.Match(TableName.Text, @"^[A-Za-z_]+$").Success)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("输入有误！");
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddNamesForms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                e.Handled = true;
                Ok_Bt_Click(sender, e);
            }
            else if (e.KeyChar == ((char)Keys.Escape))
            {
                e.Handled = true;
                Cancel_bt_Click(sender, e);
            }
        }
    }
}
