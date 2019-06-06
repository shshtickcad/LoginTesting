using DevExpress.XtraEditors;
using logInTesting.Controllers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logInTesting.Forms
{
    public partial class Form_delete : DevExpress.XtraEditors.XtraForm
    {
        private readonly UserController _userCtr;

        public Form_delete()
        {
            _userCtr = new UserController(ConfigClient._client);
            InitializeComponent();

        }

        private async void buttonDelete_ClickAsync(object sender, EventArgs e)
        {
           await _userCtr.DeleteUser(textUsername.Text);

            resetFields();
        }
        private void resetFields()
        {
            textUsername.Text = "";
            //textEmail.Text = "";
        }
    }
}