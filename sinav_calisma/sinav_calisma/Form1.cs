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
namespace sinav_calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M05476S\SQLEXPRESS;Initial Catalog=sinema;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_kullanicilar",conn);
            SqlDataReader oku = komut.ExecuteReader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_giris_paneli grs = new login_giris_paneli();
            grs.ShowDialog();
        }
    }
}
