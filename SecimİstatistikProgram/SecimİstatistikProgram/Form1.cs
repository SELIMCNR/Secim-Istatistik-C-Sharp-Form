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
namespace SecimİstatistikProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Data Source=DESKTOP-BC3LOP2\SELM;Initial Catalog=DbEntityUrun;Integrated Security=True;
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SELM;Initial Catalog=DBSECİMPROJE;Integrated Security=True;");
        private void Btn_oy_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_ILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)",baglanti);
            komut.Parameters.AddWithValue("@P1",Txt_ilce.Text);
            komut.Parameters.AddWithValue("@P2",Txt_Aparti.Text);
            komut.Parameters.AddWithValue("@P3",Txt_Bparti.Text);
            komut.Parameters.AddWithValue("@P4", Txt_Cparti.Text);
            komut.Parameters.AddWithValue("@P5",Txt_Dparti.Text);
            komut.Parameters.AddWithValue("@P6",Txt_Eparti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girisi Gerçeklesti");
        }

        private void Btn_grafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
