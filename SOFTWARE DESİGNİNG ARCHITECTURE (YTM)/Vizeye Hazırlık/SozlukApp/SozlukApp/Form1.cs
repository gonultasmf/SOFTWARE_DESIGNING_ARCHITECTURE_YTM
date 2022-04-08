using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SozlukApp
{
    public partial class Form1 : Form
    {
        DBManager db;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new DBManager(new LiteDB(), "");
            db.Search(textBox1.Text);
        }
    }
}
