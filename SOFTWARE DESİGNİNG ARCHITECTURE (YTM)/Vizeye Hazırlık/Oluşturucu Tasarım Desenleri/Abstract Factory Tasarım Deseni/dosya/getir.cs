using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknikservis
{
    public partial class getir : Form
    {

        public getir()
        {
            InitializeComponent();
        }
        DinamikDB dinamikDB = new DinamikDB();
        private void getir_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri
            {
                adsoyad = adsoyad.Text,
                tc = tc.Text,
                telefon1 = telefon1.Text,
                telefon2 = telefon2.Text,
                mail = mail.Text,
                adres = adres.Text

            };
            dinamikDB.Ekle("musteriler",musteri);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici
            {
              kullaniciadi=adsoyad.Text,
              sifre=tc.Text,
              yetki=telefon1.Text,
              cepno=telefon2.Text,
              mail=mail.Text,
              adsoyad=adres.Text
              
            };
            dinamikDB.Ekle("admin", kullanici);
        }
    }
}
