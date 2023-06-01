namespace ToolBox.Forms
{
    partial class AddToolsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToolsPath = new System.Windows.Forms.TextBox();
            this.ViewPath = new System.Windows.Forms.Button();
            this.ToolsName = new System.Windows.Forms.TextBox();
            this.OkBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "名称：";
            // 
            // ToolsPath
            // 
            this.ToolsPath.Location = new System.Drawing.Point(69, 6);
            this.ToolsPath.Name = "ToolsPath";
            this.ToolsPath.Size = new System.Drawing.Size(394, 26);
            this.ToolsPath.TabIndex = 0;
            // 
            // ViewPath
            // 
            this.ViewPath.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ViewPath.Location = new System.Drawing.Point(470, 9);
            this.ViewPath.Name = "ViewPath";
            this.ViewPath.Size = new System.Drawing.Size(54, 23);
            this.ViewPath.TabIndex = 5;
            this.ViewPath.Text = "浏览";
            this.ViewPath.UseVisualStyleBackColor = true;
            this.ViewPath.Click += new System.EventHandler(this.ViewPath_Click);
            // 
            // ToolsName
            // 
            this.ToolsName.Location = new System.Drawing.Point(69, 38);
            this.ToolsName.Name = "ToolsName";
            this.ToolsName.Size = new System.Drawing.Size(334, 26);
            this.ToolsName.TabIndex = 1;
            // 
            // OkBt
            // 
            this.OkBt.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OkBt.Location = new System.Drawing.Point(409, 41);
            this.OkBt.Name = "OkBt";
            this.OkBt.Size = new System.Drawing.Size(54, 23);
            this.OkBt.TabIndex = 5;
            this.OkBt.Text = "确定";
            this.OkBt.UseVisualStyleBackColor = true;
            this.OkBt.Click += new System.EventHandler(this.OkBt_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelBt.Location = new System.Drawing.Point(470, 41);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(54, 23);
            this.CancelBt.TabIndex = 6;
            this.CancelBt.Text = "取消";
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // AddToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 72);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.OkBt);
            this.Controls.Add(this.ToolsName);
            this.Controls.Add(this.ViewPath);
            this.Controls.Add(this.ToolsPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddToolsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddToolsForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ToolsPath;
        private System.Windows.Forms.Button ViewPath;
        public System.Windows.Forms.TextBox ToolsName;
        private System.Windows.Forms.Button OkBt;
        private System.Windows.Forms.Button CancelBt;
    }
}