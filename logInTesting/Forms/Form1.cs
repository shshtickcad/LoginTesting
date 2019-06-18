using DevExpress.XtraBars.Ribbon;
using logInTesting.Controllers;

namespace logInTesting.Forms
{
    public partial class Form1 : RibbonForm
    {
        private readonly UserController _userCtr;

        public static string loggedUser;

        private async void Form1_Shown(object sender, System.EventArgs e)
        {
            string user = await _userCtr.GetLoggedUser(loggedUser);


            barButtonItem_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            barButtonItem_Edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            view_barButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            if (user == "Admin")
            {
                barButtonItem_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barButtonItem_Edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                view_barButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //comboBoxEdit1.Visible = false;
            }
            else if (user == "Employee")
            {
                view_barButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barButtonItem_Edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        public Form1()
        {
            //ConfigClient.InitializeClient();
            InitializeComponent();
            _userCtr = new UserController(ConfigClient._client);

        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_reg fg = new Form_reg();
            fg.ShowDialog();
        }

        private void barButtonItem_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_delete fd = new Form_delete();
            fd.ShowDialog();
        }

        private void simpleButtonLogOut_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_login fl = new Form_login();
            fl.ShowDialog();
        }

        private void barButtonItem_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_edit fe = new Form_edit();
            fe.ShowDialog();
        }

        private void view_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_view fv = new Form_view();
            fv.Show();
        }
    }
}
