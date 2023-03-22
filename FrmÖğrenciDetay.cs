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


namespace Not_Kayit_Sistemi
{
    public partial class FrmÖğrenciDetay : Form
    {
        public FrmÖğrenciDetay()
        {
            InitializeComponent();
        }

        public string numara;
        SqlConnection baglanti=new SqlConnection(@"Data Source=IBRAHIMYEGEN;Initial Catalog=DbNotKayit;Integrated Security=True");
        //Data Source=IBRAHIMYEGEN;Initial Catalog=DbNotKayit;Integrated Security=True
        private void FrmÖğrenciDetay_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;
            baglanti.Open();

            SqlCommand komut=new SqlCommand("Select * from TBlDERS where OGRNUMARA=@p1 ",baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text=dr[2].ToString()+dr[3].ToString();
                lblsınav1.Text=dr[4].ToString();
                lblsınav2.Text=dr[5].ToString();  
                lblsınav3.Text=dr[6].ToString();
                lblortalama.Text=dr[7].ToString();
                lbldurum.Text=dr[8].ToString(); 

            }
            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
