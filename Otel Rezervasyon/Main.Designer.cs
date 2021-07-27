
namespace Otel_Rezervasyon
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusteri = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHareketGiris = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnAnaSayfa,
            this.BtnMusteri,
            this.BtnHareketGiris});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1902, 183);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Caption = "ANA SAYFA";
            this.BtnAnaSayfa.Id = 1;
            this.BtnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnaSayfa.ImageOptions.Image")));
            this.BtnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAnaSayfa.ImageOptions.LargeImage")));
            this.BtnAnaSayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAnaSayfa_ItemClick);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Caption = "MÜŞTERİLER";
            this.BtnMusteri.Id = 2;
            this.BtnMusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusteri.ImageOptions.Image")));
            this.BtnMusteri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteri.ImageOptions.LargeImage")));
            this.BtnMusteri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteri.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMusteri_ItemClick);
            // 
            // BtnHareketGiris
            // 
            this.BtnHareketGiris.Caption = "HAREKET GİRİŞİ";
            this.BtnHareketGiris.Id = 3;
            this.BtnHareketGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHareketGiris.ImageOptions.Image")));
            this.BtnHareketGiris.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnHareketGiris.ImageOptions.LargeImage")));
            this.BtnHareketGiris.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHareketGiris.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnHareketGiris.Name = "BtnHareketGiris";
            this.BtnHareketGiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnHareketGiris_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMusteri);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnHareketGiris);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Güneş Otel Rezervasyon Programı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem BtnMusteri;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnHareketGiris;
    }
}

