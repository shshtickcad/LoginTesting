using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using logInTesting.Controllers;
using System;
using System.Collections.Generic;
using TickToolCloud.Entities.Entity;

namespace logInTesting.Forms
{
    public partial class Form_edit : XtraForm
    {
        private readonly UserController _userCtr;

        public Form_edit()
        {
            _userCtr = new UserController(ConfigClient._client);
            InitializeComponent();
        }

        private async void Form_edit_Load(object sender, EventArgs e)
        {
            lookUpEdit.Properties.DataSource = await _userCtr.GetUsers();

            lookUpEdit.Properties.DisplayMember = "UserName";

            lookUpEdit.Properties.ValueMember = "id";

            LookUpColumnInfo col;

            col = new LookUpColumnInfo("UserName", "User Name", 100);

            col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            lookUpEdit.Properties.Columns.Add(col);
        }

        private void lookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            User usr =  (User)lookUpEdit.GetSelectedDataRow();
            email_text.Text = usr.Email;
            fname_text.Text = usr.FirstName;
            lname_textfield.Text = usr.LastName;
            company_text.Text = usr.Company;
            comboBoxEdit2.Text = usr.Role;
        }

        private async void save_simpleButton_Click(object sender, EventArgs e)
        {
            User usr = (User)lookUpEdit.GetSelectedDataRow();

            User user = new User
            {
                UserName = lookUpEdit.Text,
                Email = email_text.Text,
                FirstName = fname_text.Text,
                LastName = lname_textfield.Text,
                Password = usr.Password,
                Company = company_text.Text,
                Role = comboBoxEdit2.Text
            };
            await _userCtr.EditUser(usr.id, user);
        }

    }
}