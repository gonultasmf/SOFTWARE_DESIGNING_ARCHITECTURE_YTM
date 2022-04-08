using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace teknikservis
{
    public class DinamikDB
    {
        string kullaniciSutun ="PRAGMA table_info(admin);";
        string sütun = "PRAGMA table_info(musteriler);";
        baglanti bgl = new baglanti();
        List<string> Musteriler = new List<string>();
        List<string> Admin = new List<string>();
        Musteri musteri = new Musteri();
        public DinamikDB()
        {
            SQLiteCommand veri = new SQLiteCommand(sütun,bgl.baglantilar());
            SQLiteDataReader dr = veri.ExecuteReader();
            while (dr.Read())
            {
                Musteriler.Add(dr[1].ToString());
            }
            dr.Close();
            bgl.baglantilar().Close();
            bgl.baglantilar().Dispose();
             veri = new SQLiteCommand(kullaniciSutun, bgl.baglantilar());
             dr = veri.ExecuteReader();
            while (dr.Read())
            {
                Admin.Add(dr[1].ToString());
            }
            dr.Close();
            bgl.baglantilar().Close();
            bgl.baglantilar().Dispose();
        }
        public void Ekle(string tabloAdi,IMusteri musteri)
        {
            string sutunAdlar = "";
            if (tabloAdi=="musteriler")
            {
                sutunAdlar = "(";
                for (int i = 1; i < Musteriler.Count; i++)
                {
                    int adet = Musteriler.Count - 1;
                    if (adet != i)
                        sutunAdlar += Musteriler[i] + ",";
                    else
                        sutunAdlar += Musteriler[i] + ")";
                } 
            }
            else if (tabloAdi=="admin")
            {
                sutunAdlar = "(";
                for (int i = 1; i < Admin.Count; i++)
                {
                    int adet = Admin.Count - 1;
                    if (adet != i)
                        sutunAdlar += Admin[i] + ",";
                    else
                        sutunAdlar += Admin[i] + ")";
                }
            }
            string sorgu = "insert into " + tabloAdi + sutunAdlar + musteri;
            SQLiteCommand ekle = new SQLiteCommand(sorgu, bgl.baglantilar());
            Console.WriteLine(sorgu);
            ekle.ExecuteNonQuery();

        }
    }
}
