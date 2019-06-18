namespace logInTesting.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_delete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.view_barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.PGSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.addUser_ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSkins = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.simpleButtonLogOut = new DevExpress.XtraEditors.SimpleButton();
            this.log_labl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 147);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(902, 342);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.barButtonItem1,
            this.barButtonItem_delete,
            this.barButtonItem_Edit,
            this.view_barButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PGSettings});
            this.ribbonControl1.Size = new System.Drawing.Size(902, 147);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add";
            this.barButtonItem1.Hint = "Add new user";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem_delete
            // 
            this.barButtonItem_delete.Caption = "Delete";
            this.barButtonItem_delete.Hint = "Delete user";
            this.barButtonItem_delete.Id = 4;
            this.barButtonItem_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_delete.ImageOptions.Image")));
            this.barButtonItem_delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_delete.ImageOptions.LargeImage")));
            this.barButtonItem_delete.Name = "barButtonItem_delete";
            this.barButtonItem_delete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_delete_ItemClick);
            // 
            // barButtonItem_Edit
            // 
            this.barButtonItem_Edit.Caption = "Edit";
            this.barButtonItem_Edit.Id = 5;
            this.barButtonItem_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Edit.ImageOptions.Image")));
            this.barButtonItem_Edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Edit.ImageOptions.LargeImage")));
            this.barButtonItem_Edit.Name = "barButtonItem_Edit";
            this.barButtonItem_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Edit_ItemClick);
            // 
            // view_barButtonItem
            // 
            this.view_barButtonItem.Caption = "View";
            this.view_barButtonItem.Hint = "View all the users.";
            this.view_barButtonItem.Id = 6;
            this.view_barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("view_barButtonItem.ImageOptions.Image")));
            this.view_barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("view_barButtonItem.ImageOptions.LargeImage")));
            this.view_barButtonItem.Name = "view_barButtonItem";
            this.view_barButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.view_barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.view_barButtonItem_ItemClick);
            // 
            // PGSettings
            // 
            this.PGSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.addUser_ribbonPageGroup,
            this.rpgSkins});
            this.PGSettings.Name = "PGSettings";
            this.PGSettings.Text = "Users";
            // 
            // addUser_ribbonPageGroup
            // 
            this.addUser_ribbonPageGroup.ItemLinks.Add(this.barButtonItem1);
            this.addUser_ribbonPageGroup.ItemLinks.Add(this.barButtonItem_Edit);
            this.addUser_ribbonPageGroup.ItemLinks.Add(this.barButtonItem_delete);
            this.addUser_ribbonPageGroup.ItemLinks.Add(this.view_barButtonItem);
            this.addUser_ribbonPageGroup.Name = "addUser_ribbonPageGroup";
            this.addUser_ribbonPageGroup.Text = "Edit Users";
            // 
            // rpgSkins
            // 
            this.rpgSkins.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rpgSkins.Name = "rpgSkins";
            this.rpgSkins.Text = "Skins";
            // 
            // simpleButtonLogOut
            // 
            this.simpleButtonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonLogOut.Location = new System.Drawing.Point(797, 31);
            this.simpleButtonLogOut.Name = "simpleButtonLogOut";
            this.simpleButtonLogOut.Size = new System.Drawing.Size(54, 23);
            this.simpleButtonLogOut.TabIndex = 4;
            this.simpleButtonLogOut.Text = "LogOut";
            this.simpleButtonLogOut.Click += new System.EventHandler(this.simpleButtonLogOut_Click);
            // 
            // log_labl
            // 
            this.log_labl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.log_labl.Location = new System.Drawing.Point(857, 36);
            this.log_labl.Name = "log_labl";
            this.log_labl.Size = new System.Drawing.Size(5, 13);
            this.log_labl.TabIndex = 2;
            this.log_labl.Text = "L";
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 489);
            this.Controls.Add(this.simpleButtonLogOut);
            this.Controls.Add(this.log_labl);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TickTool Cloud";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage PGSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSkins;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup addUser_ribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_delete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Edit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogOut;
        private DevExpress.XtraBars.BarButtonItem view_barButtonItem;
        private DevExpress.XtraEditors.LabelControl log_labl;
    }
}
