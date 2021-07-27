using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void GrOda1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        AnaSayfa ana;
        private void Form1_Load(object sender, EventArgs e)
        {
            ana = new AnaSayfa();
            ana.MdiParent = this;
            ana.Show();
        }
        Musteriler ms;
        private void BtnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ms = new Musteriler();
            ms.MdiParent = this;
            ms.Show();
          
        }

        
        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ana = new AnaSayfa();
            ana.MdiParent = this;
            ana.Show();

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            Hareket_Giris hr;
            hr = new Hareket_Giris();
            hr.MdiParent = this;
            hr.Show();
        }

        private void BtnHareketGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
