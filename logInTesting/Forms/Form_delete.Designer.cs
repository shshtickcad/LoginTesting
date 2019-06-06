namespace logInTesting.Forms
{
    partial class Form_delete
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
            this.label_Username = new DevExpress.XtraEditors.LabelControl();
            this.textUsername = new DevExpress.XtraEditors.TextEdit();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Appearance.Options.UseFont = true;
            this.label_Username.Location = new System.Drawing.Point(12, 39);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(101, 25);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username ";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(130, 41);
            this.textUsername.Name = "textUsername";
            this.textUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Properties.Appearance.Options.UseFont = true;
            this.textUsername.Size = new System.Drawing.Size(142, 26);
            this.textUsername.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.buttonDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Appearance.Options.UseBackColor = true;
            this.buttonDelete.Appearance.Options.UseFont = true;
            this.buttonDelete.Location = new System.Drawing.Point(93, 106);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_ClickAsync);
            // 
            // Form_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete User";
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label_Username;
        private DevExpress.XtraEditors.TextEdit textUsername;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
    }
}