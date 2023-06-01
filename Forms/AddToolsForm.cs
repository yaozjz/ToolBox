using System;
using System.Windows.Forms;

namespace ToolBox.Forms
{
    public partial class AddToolsForm : Form
    {
        public AddToolsForm()
        {
            InitializeComponent();
        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            if (ToolsPath.Text.Trim() != "" && ToolsName.Text.Trim() != "")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("输入有误");
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void AddToolsForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ((char)Keys.Enter))
            {
                e.Handled = true;
                OkBt_Click(sender, e);
            }
            else if(e.KeyChar== ((char)Keys.Escape))
            {
                e.Handled = true;
                CancelBt_Click(sender, e );
            }
        }

        private void ViewPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "游戏启动程序";
            dlg.DefaultExt = ".exe";
            dlg.Filter = "游戏启动|*.exe";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string _path = dlg.FileName;
                ToolsPath.Text = _path;
                ToolsName.Text = System.IO.Path.GetFileNameWithoutExtension(_path);
            }
            dlg.Dispose();
        }
    }
}
