using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iki_tarih_arasındaki_farkı_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugunTarihi = DateTime.Now;// bugünün tarihi
            DateTime cıkacaktarih = dateTimePicker1.Value;// çıkacak  tarih

            TimeSpan ts = cıkacaktarih - bugunTarihi;// tarihler arasındaki fark

            lblcıkacak.Text = "Çıkarılacak Tarih : " + cıkacaktarih.ToShortDateString();// çıkacak tarih label'ını ayarla
            lblKalanGun.Text = "Kalan Gün : " + ts.Days.ToString();// kalan günleri label'ını ayarla

        }
    }
}
