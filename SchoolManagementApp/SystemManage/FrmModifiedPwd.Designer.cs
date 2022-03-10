
namespace SchoolManagementApp.SystemManage
{
    partial class FrmModifiedPwd
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
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.tetOldPwd = new System.Windows.Forms.TextBox();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.lblAgainPwd = new System.Windows.Forms.Label();
            this.txtAgainPwd = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.Location = new System.Drawing.Point(86, 83);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(80, 18);
            this.lblOldPwd.TabIndex = 0;
            this.lblOldPwd.Text = "旧密码 :";
            // 
            // tetOldPwd
            // 
            this.tetOldPwd.Location = new System.Drawing.Point(199, 80);
            this.tetOldPwd.Name = "tetOldPwd";
            this.tetOldPwd.PasswordChar = '*';
            this.tetOldPwd.Size = new System.Drawing.Size(309, 28);
            this.tetOldPwd.TabIndex = 1;
            this.tetOldPwd.TextChanged += new System.EventHandler(this.tetOldPwd_TextChanged);
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(86, 184);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(80, 18);
            this.lblNewPwd.TabIndex = 2;
            this.lblNewPwd.Text = "新密码 :";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(199, 174);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(309, 28);
            this.txtNewPwd.TabIndex = 3;
            // 
            // lblAgainPwd
            // 
            this.lblAgainPwd.AutoSize = true;
            this.lblAgainPwd.Location = new System.Drawing.Point(50, 284);
            this.lblAgainPwd.Name = "lblAgainPwd";
            this.lblAgainPwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAgainPwd.Size = new System.Drawing.Size(116, 18);
            this.lblAgainPwd.TabIndex = 4;
            this.lblAgainPwd.Text = "确认新密码 :";
            this.lblAgainPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAgainPwd
            // 
            this.txtAgainPwd.Location = new System.Drawing.Point(199, 284);
            this.txtAgainPwd.Name = "txtAgainPwd";
            this.txtAgainPwd.PasswordChar = '*';
            this.txtAgainPwd.Size = new System.Drawing.Size(309, 28);
            this.txtAgainPwd.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Location = new System.Drawing.Point(120, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirm.Location = new System.Drawing.Point(343, 370);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(124, 35);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // FrmModifiedPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 457);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAgainPwd);
            this.Controls.Add(this.lblAgainPwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.tetOldPwd);
            this.Controls.Add(this.lblOldPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmModifiedPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmModifiedPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPwd;
        private System.Windows.Forms.TextBox tetOldPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label lblAgainPwd;
        private System.Windows.Forms.TextBox txtAgainPwd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirm;
    }
}