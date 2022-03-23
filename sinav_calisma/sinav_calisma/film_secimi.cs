using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sinav_calisma
{
    public partial class film_secimi : Form
    {
        public film_secimi()
        {
            InitializeComponent();
        }




        public static string film_adi = "";
        private void _filmsec(object sender, EventArgs e)
        {
            film_adi =(sender as PictureBox).Name;
            koltuksecimi sec = new koltuksecimi();
            sec.ShowDialog();


        }
    
    }
}
