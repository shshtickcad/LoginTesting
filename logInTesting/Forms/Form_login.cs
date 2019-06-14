using DevExpress.XtraEditors;
using logInTesting.Controllers;
using System;
using System.Windows.Forms;
using TickToolCloud.Entities.Entity;

namespace logInTesting.Forms
{
    public partial class Form_login : XtraForm
    {
        private readonly UserController _userCtr;

        bool IsDone = false;

        public Form_login()
        {
            ConfigClient.InitializeClient();
            _userCtr = new UserController(ConfigClient._client);
            InitializeComponent();
        }

        private async void Okb_Click(object sender, EventArgs e)
        {
            if (userName_textEdit.Text == string.Empty)
            {
                userName_textEdit.Select();
                return;
            }

            LoginModel login = new LoginModel
            {
                loginName = userName_textEdit.Text,
                password = password_textEdit.Text
            };

            var result = await _userCtr.checkUsers(login);

            IsDone = result ? true : false;

            //IsDone = userName_textEdit.Text != "" && userName_textEdit.Text == "shsh" &&
            //password_textEdit.Text == "123" && password_textEdit.Text != "" ? true : false;

            //if (save_checkBox.Checked == true)
            //{
            Properties.Settings.Default.UserName = userName_textEdit.Text;
            Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Properties.Settings.Default.UserName = "";
            //    Properties.Settings.Default.Save();
            //}

            if (!IsDone) 
            {
                XtraMessageBox.Show("Username or Password is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_textEdit.Text = "";
            }
            else
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            Close();
        }

        //public static bool IsActive()
        //{
        //    Form_login login = new Form_login();
        //    login.ShowDialog();
        //    return login.IsDone ? true : false;
        //}

        private void cancelB_Click(object sender, EventArgs e)
        {
            IsDone = false;
            Close();
        }      

        private void Form_login_Load(object sender, EventArgs e)
        {
            userName_textEdit.Text = Properties.Settings.Default.UserName;
        }
    }
}