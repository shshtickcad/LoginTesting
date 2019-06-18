using DevExpress.XtraEditors;
using logInTesting.Controllers;
using System;

namespace logInTesting.Forms
{
    public partial class Form_view : XtraForm
    {
        private readonly UserController _userCtr;

        public Form_view()
        {
            _userCtr = new UserController(ConfigClient._client);
            InitializeComponent();
        }

        private async void Form_view_Load(object sender, EventArgs e)
        {
            var ds = await _userCtr.GetUsers();
            gridControl.DataSource = ds;
        }
    }
}