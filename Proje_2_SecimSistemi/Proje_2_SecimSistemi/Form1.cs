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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ŞEYMA\SQLEXPRESS;Initial Catalog=DBSECİMSİSTEMİ;Integrated Security=True");
        private void BtnOyGirisiYap_Click(object sender, EventArgs e)
        {   
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSECİMSİSTEMİ (ILCEAD,APARTİ,BPARTİ,CPARTİ,DPARTİ,EPARTİ) values(@P1,@P2,@P3,@P4,@P5,@P6)");
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@P1",TxtBxIlceAdi.Text);
            komut.Parameters.AddWithValue("@P2",TxtBxAPartisi.Text);
            komut.Parameters.AddWithValue("@P3", TxtBxBPartisi.Text);
            komut.Parameters.AddWithValue("@P4", TxtBxCPartisi.Text);
            komut.Parameters.AddWithValue("@P5", TxtBxDPartisi.Text);
            komut.Parameters.AddWithValue("@P6", TxtBxEPartisi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("OY GİRİŞİ GERÇEKLEŞTİ");

            



        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void BtnCikisYap_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Close();
        }
    }
}
