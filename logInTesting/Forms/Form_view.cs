using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using logInTesting.Controllers;

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
            var ds = await _userCtr.getUsers();
            gridControl.DataSource = ds;
        }
    }
}