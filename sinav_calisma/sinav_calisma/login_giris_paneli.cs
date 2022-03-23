using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sinav_calisma
{
    public partial class login_giris_paneli : Form
    {
        public login_giris_paneli()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M05476S\SQLEXPRESS;Initial Catalog=sinema;Integrated Security=True");

        public static string kullanici_adi = "";
        public static string sifre = "";
        private void button1_Click(object sender, EventArgs e)
        {
            bool login_kontrol = false;
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_kullanicilar", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (textBox1.Text==oku["kullanici_adi"].ToString()&& textBox2.Text==oku["sifre"].ToString())
                {
                    login_kontrol = true;
                }
            }
            if (login_kontrol=true)
            {
                kullanici_adi = textBox1.Text;
                sifre = textBox2.Text;
                film_secimi sec = new film_secimi();
                this.Hide();
                sec.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }
            conn.Close();
        }
    }
}
