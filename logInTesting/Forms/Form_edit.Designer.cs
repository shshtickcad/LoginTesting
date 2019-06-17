namespace logInTesting.Forms
{
    partial class Form_edit
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
            this.labelWelcome = new DevExpress.XtraEditors.LabelControl();
            this.save_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.lname_textfield = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.company_text = new DevExpress.XtraEditors.TextEdit();
            this.label_role = new DevExpress.XtraEditors.LabelControl();
            this.label_company = new DevExpress.XtraEditors.LabelControl();
            this.fname_text = new DevExpress.XtraEditors.TextEdit();
            this.label_name = new DevExpress.XtraEditors.LabelControl();
            this.email_text = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lname_textfield.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fname_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_text.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Appearance.Options.UseFont = true;
            this.labelWelcome.Location = new System.Drawing.Point(257, 12);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(109, 19);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Edit User Detail";
            // 
            // save_simpleButton
            // 
            this.save_simpleButton.Location = new System.Drawing.Point(272, 162);
            this.save_simpleButton.Name = "save_simpleButton";
            this.save_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.save_simpleButton.TabIndex = 2;
            this.save_simpleButton.Text = "Save";
            this.save_simpleButton.Click += new System.EventHandler(this.save_simpleButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "UserName ";
            // 
            // lookUpEdit
            // 
            this.lookUpEdit.Location = new System.Drawing.Point(115, 57);
            this.lookUpEdit.Name = "lookUpEdit";
            this.lookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit.Size = new System.Drawing.Size(154, 26);
            this.lookUpEdit.TabIndex = 7;
            this.lookUpEdit.EditValueChanged += new System.EventHandler(this.lookUpEdit_EditValueChanged);
            // 
            // lname_textfield
            // 
            this.lname_textfield.Location = new System.Drawing.Point(115, 120);
            this.lname_textfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lname_textfield.Name = "lname_textfield";
            this.lname_textfield.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_textfield.Properties.Appearance.Options.UseFont = true;
            this.lname_textfield.Size = new System.Drawing.Size(154, 24);
            this.lname_textfield.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 121);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 19);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "Last Name ";
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.AllowDrop = true;
            this.comboBoxEdit2.Location = new System.Drawing.Point(443, 59);
            this.comboBoxEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit2.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "Guest",
            "Customer",
            "Employee",
            "Admin"});
            this.comboBoxEdit2.Size = new System.Drawing.Size(107, 24);
            this.comboBoxEdit2.TabIndex = 30;
            // 
            // company_text
            // 
            this.company_text.Location = new System.Drawing.Point(443, 90);
            this.company_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.company_text.Name = "company_text";
            this.company_text.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_text.Properties.Appearance.Options.UseFont = true;
            this.company_text.Size = new System.Drawing.Size(149, 24);
            this.company_text.TabIndex = 29;
            // 
            // label_role
            // 
            this.label_role.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.Appearance.Options.UseFont = true;
            this.label_role.Location = new System.Drawing.Point(383, 60);
            this.label_role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(36, 19);
            this.label_role.TabIndex = 31;
            this.label_role.Text = "Role ";
            // 
            // label_company
            // 
            this.label_company.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company.Appearance.Options.UseFont = true;
            this.label_company.Location = new System.Drawing.Point(347, 88);
            this.label_company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_company.Name = "label_company";
            this.label_company.Size = new System.Drawing.Size(72, 19);
            this.label_company.TabIndex = 26;
            this.label_company.Text = "Company ";
            // 
            // fname_text
            // 
            this.fname_text.Location = new System.Drawing.Point(115, 88);
            this.fname_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fname_text.Name = "fname_text";
            this.fname_text.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_text.Properties.Appearance.Options.UseFont = true;
            this.fname_text.Size = new System.Drawing.Size(154, 24);
            this.fname_text.TabIndex = 21;
            // 
            // label_name
            // 
            this.label_name.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Appearance.Options.UseFont = true;
            this.label_name.Location = new System.Drawing.Point(11, 91);
            this.label_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(81, 19);
            this.label_name.TabIndex = 20;
            this.label_name.Text = "First Name ";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(443, 120);
            this.email_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_text.Name = "email_text";
            this.email_text.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Properties.Appearance.Options.UseFont = true;
            this.email_text.Size = new System.Drawing.Size(149, 24);
            this.email_text.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(369, 121);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 19);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "E-mail ";
            // 
            // Form_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 203);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lname_textfield);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.comboBoxEdit2);
            this.Controls.Add(this.company_text);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.label_company);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.lookUpEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.save_simpleButton);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.Form_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lname_textfield.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fname_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_text.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelWelcome;
        private DevExpress.XtraEditors.SimpleButton save_simpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit;
        private DevExpress.XtraEditors.TextEdit lname_textfield;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.TextEdit company_text;
        private DevExpress.XtraEditors.LabelControl label_role;
        private DevExpress.XtraEditors.LabelControl label_company;
        private DevExpress.XtraEditors.TextEdit fname_text;
        private DevExpress.XtraEditors.LabelControl label_name;
        private DevExpress.XtraEditors.TextEdit email_text;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}