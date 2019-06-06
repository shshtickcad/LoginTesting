using DevExpress.XtraEditors;
using logInTesting.Controllers;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TickToolCloud.Entities.Entity;

namespace logInTesting.Forms
{
    public partial class Form_reg : XtraForm
    {
        private readonly UserController _userCtr;

        public Form_reg()
        {
            _userCtr = new UserController(ConfigClient._client);
            InitializeComponent();

            if(Properties.Settings.Default.UserName != "admin")
            {
                //comboBoxEdit1.Enabled = false;
                label_role.Visible = false;
                comboBoxEdit1.Visible = false;
            }
        }

        private void backB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void submitB_Click(object sender, EventArgs e)
        {
            #region CHECK USERNAME AND EMAIL FIELD
            if (string.IsNullOrEmpty(usrname_textfield.Text) || string.IsNullOrEmpty(email_text.Text))
            {
                XtraMessageBox.Show("All the fields marked * must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region Verify the email.
            string epattern = @"^([\w]+)@([\w]+)\.([\w]+)$";
            if (!Regex.IsMatch(email_text.Text, epattern))
            {
                XtraMessageBox.Show("E-mail is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region CHECK PASSWORD AND RE-PASSWORD
            if (string.IsNullOrEmpty(password_text.Text) || !password_text.Text.Equals(rePassword_text.Text))
            {
                XtraMessageBox.Show("Password and re-Password doesn't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region CHECK IF EMAIL ALREADY EXISTS
            var result = await _userCtr.checkEmail(email_text.Text);
            if (result != true)
            {
                XtraMessageBox.Show("User with same E-mail already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion


            User usr = new User
            {
                UserName = usrname_textfield.Text,
                Email = email_text.Text,
                FirstName = fname_text.Text,
                LastName = lname_textfield.Text,
                Password = password_text.Text,
                Company = company_text.Text,
                Role = comboBoxEdit1.Text
            };
            await _userCtr.AddUser(usr);
            resetFields();
        }

        private void resetFields()
        {
            fname_text.Text = "";
            lname_textfield.Text = "";
            usrname_textfield.Text = "";
            email_text.Text = "";
            password_text.Text = "";
            rePassword_text.Text = "";
            company_text.Text = "";
            comboBoxEdit1.Text = "";
        }
    }
}