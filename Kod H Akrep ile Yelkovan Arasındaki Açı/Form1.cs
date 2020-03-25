using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kod_H_Akrep_ile_Yelkovan_Arasındaki_Açı
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        int Saat, Dakika;
        double KAci, BAci;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }


        private void PicKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicSimge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void Onay_Click(object sender, EventArgs e)
        {
            string[] Zaman = maskedTextBox1.Text.Split(':');
            Saat = Convert.ToInt16(Zaman[0]) % 12;
            Dakika = Convert.ToInt16(Zaman[1]);


            KAci = Math.Abs((Saat * 30) - (Dakika * 6));
            BAci = 360 - KAci;

            if (BAci > KAci)
            {
                TxtKaci.Text = KAci.ToString();
                TxtBaci.Text = BAci.ToString();
            }

            else
            {
                TxtKaci.Text = BAci.ToString();
                TxtBaci.Text = KAci.ToString();
            }

            GAcı.Visible = true;
        }

        
    }
}
