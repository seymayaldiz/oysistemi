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



namespace Proje_2_SecimSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ŞEYMA\SQLEXPRESS;Initial Catalog=DBSECİMSİSTEMİ;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {  // COMBOBOX'A İLÇELERİ ÇEKİYORUZ
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEAD from TBLSECİMSİSTEMİ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbbxIlceSecin.Items.Add(dr[0]);
            }

            baglanti.Close();

            //GRAFİĞE TOPLAM SONUÇLARI GETİRİYORUZ


            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select SUM(APARTİ),SUM(BPARTİ),SUM(CPARTİ),SUM(DPARTİ),SUM(EPARTİ) from TBLSECİMSİSTEMİ");
            komut2.Connection = baglanti;
            SqlDataReader dr2 = komut2.ExecuteReader();
            
            while (dr2.Read())
            {

                chart1.Series["PARTİLER"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["PARTİLER"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["PARTİLER"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["PARTİLER"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["PARTİLER"].Points.AddXY("E PARTİ", dr2[4]);


            }

            baglanti.Close();


        }

        private void CmbbxIlceSecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLSECİMSİSTEMİ where ILCEAD=@P1",baglanti);
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@P1",CmbbxIlceSecin.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());


                LblA.Text = dr[2].ToString();
                LblB.Text = dr[3].ToString();
                LblC.Text = dr[4].ToString();
                LblD.Text = dr[5].ToString();
                LblE.Text = dr[6].ToString();



            }
            baglanti.Close();

        }
    }


}
