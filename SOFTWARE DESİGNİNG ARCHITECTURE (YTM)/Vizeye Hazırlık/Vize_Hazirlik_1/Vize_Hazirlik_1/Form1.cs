using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Hazirlik_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mudur mudur = new Mudur();
            MessageBox.Show(mudur.KayitEkle());
            MessageBox.Show(mudur.KayitSil());
            MessageBox.Show(mudur.KayitGuncelle());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Isci isci = new Isci();
            MessageBox.Show(isci.SifreDegis());
        }
    }
}
