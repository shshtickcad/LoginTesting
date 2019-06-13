using DevExpress.XtraEditors;
using logInTesting.Controllers;
using System;

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

        private async void gridControl1_Load(object sender, EventArgs e)
        {
            var ds = await _userCtr.getUsers();
            gridControl1.DataSource = ds;
        }
    }
}