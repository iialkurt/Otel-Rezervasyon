using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otel_Rezervasyon
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
          
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }


        void sehirlistesi()
        {

            SqlCommand komut = new SqlCommand("select sehir from TBL_SEHIRLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIl.Properties.Items.Add(dr[0]);
                bgl.baglanti().Close();
            }
        }
        private void Musteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
        }

    

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtAdi.Text = dr["ADI"].ToString();
            TxtSoyadi.Text = dr["SOYADI"].ToString();
            TxtTcNo.Text = dr["TC_NO"].ToString();
            TxtTelefon.Text = dr["TELEFON"].ToString();
            CmbIl.Text = dr["IL"].ToString();
            CmbIlce.Text = dr["ILCE"].ToString();
            RchAdres.Text = dr["ADRES"].ToString();
            LblId.Text = dr["ID"].ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (ADI,SOYADI,TC_NO,TELEFON,IL,ILCE,ADRES) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgl.baglanti());
            komut.Parameters.AddWithValue("p1",TxtAdi.Text);
            komut.Parameters.AddWithValue("p2", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("p3", TxtTcNo.Text);
            komut.Parameters.AddWithValue("p4", TxtTelefon.Text);
            komut.Parameters.AddWithValue("p5", CmbIl.Text);
            komut.Parameters.AddWithValue("p6", CmbIlce.Text);
            komut.Parameters.AddWithValue("p7", RchAdres.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from TBL_MUSTERILER where ID=@p0",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p0", LblId.Text);
            komutsil.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Başarıyla Silindi", "Müşteri Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxEdit1_Properties_Click(object sender, EventArgs e)
        {
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ilce from TBL_ILCELER Where Sehir= @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbIl.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Properties.Items.Add(dr[0]);

            }

        }
    }
}
