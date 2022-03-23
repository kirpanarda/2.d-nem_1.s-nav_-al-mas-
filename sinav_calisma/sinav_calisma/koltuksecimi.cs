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
    public partial class koltuksecimi : Form
    {
        public koltuksecimi()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M05476S\SQLEXPRESS;Initial Catalog=sinema;Integrated Security=True");

        public static string film = "";

        private void koltuksecimi_Load(object sender, EventArgs e)
        {
            if (film_secimi.film_adi=="picturebox1")
            {
                film ="kırmızı";
            }
            else if (film_secimi.film_adi=="picturebox2")
            {
                film = "batman";
            }
            
            
            
            
            
            int buton_sayisi = 100;
            int x = 30;
            int y = 35;
            int artis_miktarix = 80;
            int artis_miktariy = 80;
            for (int i = 0; i <= buton_sayisi; i++)
            {
                Button koltuk = new Button();
                koltuk.Name = "koltuk" + i.ToString();
                koltuk.Text = i.ToString() + "numaralı koltuk";
                koltuk.Size = new Size(65, 60); // buton büyüklüğü
                koltuk.FlatStyle = FlatStyle.Flat;
                koltuk.BackColor = Color.Green; //buton rengi
                koltuk.ForeColor = Color.White; //butonun içindeki yazı rengi
                koltuk.Click += Koltuk_Click;
                koltuk.Location = new Point(x,y);
                x =x+ artis_miktarix;

                if (i % 8 ==0)
                {
                    x = 30;
                    y = y + artis_miktariy;
                    groupBox1.Controls.Add(koltuk);
                }

                
                //MessageBox.Show("eklendi");

                foreach (Control dolukoltuklar in groupBox1.Controls)
                {
                    if (dolukoltuklar is Button)
                    {
                        conn.Open();
                        SqlCommand komut = new SqlCommand("SELECT * FROM tbl_koltuk_secimi WHERE film_adi ='" + film+ "' AND koltuk_no ='" + dolukoltuklar.Name+"'",conn);
                        SqlDataReader oku = komut.ExecuteReader();
                        if (oku.HasRows)
                        {
                            dolukoltuklar.BackColor = Color.Red;
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void Koltuk_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void koltuk(object sender, EventArgs e)
        {

        }
    }
}
