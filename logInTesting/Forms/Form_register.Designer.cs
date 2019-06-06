namespace logInTesting.Forms
{
    partial class Form_reg
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
            this.label_name = new DevExpress.XtraEditors.LabelControl();
            this.label_Password = new DevExpress.XtraEditors.LabelControl();
            this.fname_text = new DevExpress.XtraEditors.TextEdit();
            this.password_text = new DevExpress.XtraEditors.TextEdit();
            this.label_company = new DevExpress.XtraEditors.LabelControl();
            this.submitB = new DevExpress.XtraEditors.SimpleButton();
            this.company_text = new DevExpress.XtraEditors.TextEdit();
            this.label_role = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.rePassword_text = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.email_text = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label_header = new DevExpress.XtraEditors.LabelControl();
            this.usrname_textfield = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lname_textfield = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.fname_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rePassword_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrname_textfield.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lname_textfield.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Appearance.Options.UseFont = true;
            this.label_name.Location = new System.Drawing.Point(45, 69);
            this.label_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(81, 19);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "First Name ";
            // 
            // label_Password
            // 
            this.label_Password.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Appearance.Options.UseFont = true;
            this.label_Password.Location = new System.Drawing.Point(46, 180);
            this.label_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(81, 19);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password* ";
            // 
            // fname_text
            // 
            this.fname_text.Location = new System.Drawing.Point(149, 69);
            this.fname_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fname_text.Name = "fname_text";
            this.fname_text.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_text.Properties.Appearance.Options.UseFont = true;
            this.fname_text.Size = new System.Drawing.Size(160, 24);
            this.fname_text.TabIndex = 1;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(149, 180);
            this.password_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_text.Name = "password_text";
            this.password_text.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Properties.Appearance.Options.UseFont = true;
            this.password_text.Properties.UseSystemPasswordChar = true;
            this.password_text.Size = new System.Drawing.Size(160, 24);
            this.password_text.TabIndex = 5;
            // 
            // label_company
            // 
            this.label_company.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company.Appearance.Options.UseFont = true;
            this.label_company.Location = new System.Drawing.Point(57, 236);
            this.label_company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_company.Name = "label_company";
            this.label_company.Size = new System.Drawing.Size(72, 19);
            this.label_company.TabIndex = 4;
            this.label_company.Text = "Company ";
            // 
            // submitB
            // 
            this.submitB.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.submitB.Appearance.Options.UseBackColor = true;
            this.submitB.Location = new System.Drawing.Point(126, 303);
            this.submitB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(81, 24);
            this.submitB.TabIndex = 9;
            this.submitB.Text = "Submit";
            this.submitB.Click += new System.EventHandler(this.submitB_Click);
            // 
            // company_text
            // 
            this.company_text.Location = new System.Drawing.Point(149, 236);
            this.company_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.company_text.Name = "company_text";
            this.company_text.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_text.Properties.Appearance.Options.UseFont = true;
            this.company_text.Size = new System.Drawing.Size(160, 24);
            this.company_text.TabIndex = 7;
            // 
            // label_role
            // 
            this.label_role.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.Appearance.Options.UseFont = true;
            this.label_role.Location = new System.Drawing.Point(89, 265);
            this.label_role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(36, 19);
            this.label_role.TabIndex = 9;
            this.label_role.Text = "Role ";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.AllowDrop = true;
            this.comboBoxEdit1.Location = new System.Drawing.Point(149, 264);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Guest",
            "Customer",
            "Employee",
            "Admin"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(107, 24);
            this.comboBoxEdit1.TabIndex = 8;
            // 
            // rePassword_text
            // 
            this.rePassword_text.Location = new System.Drawing.Point(149, 208);
            this.rePassword_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rePassword_text.Name = "rePassword_text";
            this.rePassword_text.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePassword_text.Properties.Appearance.Options.UseFont = true;
            this.rePassword_text.Properties.UseSystemPasswordChar = true;
            this.rePassword_text.Size = new System.Drawing.Size(160, 24);
            this.rePassword_text.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 208);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Re-Password ";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(149, 153);
            this.email_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_text.Name = "email_text";
            this.email_text.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Properties.Appearance.Options.UseFont = true;
            this.email_text.Size = new System.Drawing.Size(160, 24);
            this.email_text.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(70, 153);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 19);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "E-mail* ";
            // 
            // label_header
            // 
            this.label_header.Appearance.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.Appearance.Options.UseFont = true;
            this.label_header.Location = new System.Drawing.Point(70, 22);
            this.label_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(182, 26);
            this.label_header.TabIndex = 16;
            this.label_header.Text = "Register New User";
            // 
            // usrname_textfield
            // 
            this.usrname_textfield.Location = new System.Drawing.Point(149, 128);
            this.usrname_textfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrname_textfield.Name = "usrname_textfield";
            this.usrname_textfield.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrname_textfield.Properties.Appearance.Options.UseFont = true;
            this.usrname_textfield.Size = new System.Drawing.Size(160, 24);
            this.usrname_textfield.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 128);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 19);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "User Name* ";
            // 
            // lname_textfield
            // 
            this.lname_textfield.Location = new System.Drawing.Point(149, 97);
            this.lname_textfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lname_textfield.Name = "lname_textfield";
            this.lname_textfield.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_textfield.Properties.Appearance.Options.UseFont = true;
            this.lname_textfield.Size = new System.Drawing.Size(160, 24);
            this.lname_textfield.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(46, 97);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 19);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Last Name ";
            // 
            // Form_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 345);
            this.Controls.Add(this.lname_textfield);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.usrname_textfield);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.rePassword_text);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.company_text);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.submitB);
            this.Controls.Add(this.label_company);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            ((System.ComponentModel.ISupportInitialize)(this.fname_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rePassword_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrname_textfield.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lname_textfield.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label_name;
        private DevExpress.XtraEditors.LabelControl label_Password;
        private DevExpress.XtraEditors.TextEdit fname_text;
        private DevExpress.XtraEditors.TextEdit password_text;
        private DevExpress.XtraEditors.LabelControl label_company;
        private DevExpress.XtraEditors.SimpleButton submitB;
        private DevExpress.XtraEditors.TextEdit company_text;
        private DevExpress.XtraEditors.LabelControl label_role;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit rePassword_text;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit email_text;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl label_header;
        private DevExpress.XtraEditors.TextEdit usrname_textfield;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit lname_textfield;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}