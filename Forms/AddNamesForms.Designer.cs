namespace ToolBox.Forms
{
    partial class AddNamesForms
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
            this.Name_Dt = new System.Windows.Forms.TextBox();
            this.Ok_Bt = new System.Windows.Forms.Button();
            this.Cancel_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name_Dt
            // 
            this.Name_Dt.Location = new System.Drawing.Point(73, 12);
            this.Name_Dt.Name = "Name_Dt";
            this.Name_Dt.Size = new System.Drawing.Size(258, 26);
            this.Name_Dt.TabIndex = 0;
            // 
            // Ok_Bt
            // 
            this.Ok_Bt.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ok_Bt.Location = new System.Drawing.Point(337, 15);
            this.Ok_Bt.Name = "Ok_Bt";
            this.Ok_Bt.Size = new System.Drawing.Size(55, 23);
            this.Ok_Bt.TabIndex = 2;
            this.Ok_Bt.Text = "确定";
            this.Ok_Bt.UseVisualStyleBackColor = true;
            this.Ok_Bt.Click += new System.EventHandler(this.Ok_Bt_Click);
            // 
            // Cancel_bt
            // 
            this.Cancel_bt.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel_bt.Location = new System.Drawing.Point(398, 15);
            this.Cancel_bt.Name = "Cancel_bt";
            this.Cancel_bt.Size = new System.Drawing.Size(55, 23);
            this.Cancel_bt.TabIndex = 2;
            this.Cancel_bt.Text = "取消";
            this.Cancel_bt.UseVisualStyleBackColor = true;
            this.Cancel_bt.Click += new System.EventHandler(this.Cancel_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "英文名（仅使用26字母及下划线\'_\'）：";
            // 
            // TableName
            // 
            this.TableName.Location = new System.Drawing.Point(267, 52);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(181, 26);
            this.TableName.TabIndex = 1;
            // 
            // AddNamesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 88);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_bt);
            this.Controls.Add(this.Ok_Bt);
            this.Controls.Add(this.Name_Dt);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNamesForms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddNamesForms_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ok_Bt;
        private System.Windows.Forms.Button Cancel_bt;
        public System.Windows.Forms.TextBox Name_Dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TableName;
    }
}