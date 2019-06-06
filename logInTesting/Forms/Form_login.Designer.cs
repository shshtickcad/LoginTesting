namespace logInTesting.Forms
{
    partial class Form_login
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
            this.userName_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.password_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.userName = new DevExpress.XtraEditors.LabelControl();
            this.password_label = new DevExpress.XtraEditors.LabelControl();
            this.Okb = new DevExpress.XtraEditors.SimpleButton();
            this.cancelB = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.userName_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // userName_textEdit
            // 
            this.userName_textEdit.Location = new System.Drawing.Point(127, 42);
            this.userName_textEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName_textEdit.Name = "userName_textEdit";
            this.userName_textEdit.Size = new System.Drawing.Size(135, 20);
            this.userName_textEdit.TabIndex = 1;
            // 
            // password_textEdit
            // 
            this.password_textEdit.Location = new System.Drawing.Point(127, 86);
            this.password_textEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_textEdit.Name = "password_textEdit";
            this.password_textEdit.Properties.UseSystemPasswordChar = true;
            this.password_textEdit.Size = new System.Drawing.Size(135, 20);
            this.password_textEdit.TabIndex = 2;
            // 
            // userName
            // 
            this.userName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Appearance.Options.UseFont = true;
            this.userName.Location = new System.Drawing.Point(31, 40);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(78, 19);
            this.userName.TabIndex = 6;
            this.userName.Text = "User Name";
            // 
            // password_label
            // 
            this.password_label.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Appearance.Options.UseFont = true;
            this.password_label.Location = new System.Drawing.Point(43, 85);
            this.password_label.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(67, 19);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password";
            // 
            // Okb
            // 
            this.Okb.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.Okb.Appearance.Options.UseBackColor = true;
            this.Okb.Location = new System.Drawing.Point(104, 143);
            this.Okb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Okb.Name = "Okb";
            this.Okb.Size = new System.Drawing.Size(81, 24);
            this.Okb.TabIndex = 3;
            this.Okb.Text = "Ok";
            this.Okb.Click += new System.EventHandler(this.Okb_Click);
            // 
            // cancelB
            // 
            this.cancelB.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.cancelB.Appearance.Options.UseBackColor = true;
            this.cancelB.Location = new System.Drawing.Point(104, 194);
            this.cancelB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(81, 24);
            this.cancelB.TabIndex = 4;
            this.cancelB.Text = "Cancel";
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // Form_login
            // 
            this.AcceptButton = this.Okb;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 247);
            this.ControlBox = false;
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.Okb);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.password_textEdit);
            this.Controls.Add(this.userName_textEdit);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userName_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit userName_textEdit;
        private DevExpress.XtraEditors.TextEdit password_textEdit;
        private DevExpress.XtraEditors.LabelControl userName;
        private DevExpress.XtraEditors.LabelControl password_label;
        private DevExpress.XtraEditors.SimpleButton Okb;
        private DevExpress.XtraEditors.SimpleButton cancelB;
    }
}