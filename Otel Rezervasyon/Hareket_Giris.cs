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
    public partial class Hareket_Giris : Form
    {
        public Hareket_Giris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void hareketlistele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_HAREKETLER ORDER BY CIKIS_TARIHI DESC", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }

        void odalistele()
        {

            SqlCommand komut = new SqlCommand("select ODA_NO From TBL_ODALAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbOdaNo.Properties.Items.Add(dr[0]);
                bgl.baglanti().Close();
            }
        }
        private void Hareket_Giris_Load(object sender, EventArgs e)
        {
            listele();
            hareketlistele();
            odalistele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtMusteriAd.Text = dr["ADI"].ToString();
            TxtMusteriSoyad.Text = dr["SOYADI"].ToString();
            LblId.Text = dr["ID"].ToString();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_HAREKETLER (MUSTERI_ID,MUSTERI_ADI,MUSTERI_SOYADI,GIRIS_TARIHI,CIKIS_TARIHI,ODA_NO,FIYAT) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            if (TxtFiyat.Text=="" || CmbOdaNo.Text=="" || DeGirisTarih.Text=="" || DeCikisTarih.Text=="")
            {
                MessageBox.Show("Lütfen Fiyat ve Oda Noyu Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            komut.Parameters.AddWithValue("p1", LblId.Text);
             komut.Parameters.AddWithValue("p2", txtMusteriAd.Text);
             komut.Parameters.AddWithValue("p3", TxtMusteriSoyad.Text);
             komut.Parameters.AddWithValue("p4", DateTime.Parse(DeGirisTarih.Text));
             komut.Parameters.AddWithValue("p5", DateTime.Parse(DeCikisTarih.Text));
             komut.Parameters.AddWithValue("p6", int.Parse(CmbOdaNo.Text));
             komut.Parameters.AddWithValue("p7", decimal.Parse(TxtFiyat.Text));
            
            komut.ExecuteNonQuery();
          hareketlistele();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void CmbOdaNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select ODA_FIYATI From TBL_ODALAR where ODA_NO=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbOdaNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               // MessageBox.Show(dr[0].ToString());
                TxtFiyat.Text = dr[0].ToString();
                bgl.baglanti().Close();
            }
        }
    }
}
