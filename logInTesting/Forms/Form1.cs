using DevExpress.XtraBars.Ribbon;

namespace logInTesting.Forms
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            //ConfigClient.InitializeClient();
            InitializeComponent();

            if (Properties.Settings.Default.UserName != "admin")
            {
                barButtonItem_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                //comboBoxEdit1.Visible = false;
            }
        }

        private void Form1_Shown(object sender, System.EventArgs e)
        {
            //if (!Form_login.IsActive())
            //{
            //    Application.Exit();
            //}
            //else
            //{
                log_labl.Text = Properties.Settings.Default.UserName;
            //}
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
    }
}
