using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teknikservis
{
   public interface IMusteri
    {
        int  id { get; set; }
    }
    public class Musteri:IMusteri
    {
        public int id { get; set; }

        public string adsoyad { get; set; }
        public string tc { get; set; }
        public string telefon1 { get; set; }
        public string telefon2 { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }

        public override string ToString()
        {
            return "values ('"+adsoyad + "','" + tc + "','" + telefon1 + "','" + telefon2 + "','" + mail + "','" + adres +"')";
        }
    }
    public class Kullanici : IMusteri
    {
        public int id { get; set; }
        public string adsoyad { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public string cepno { get; set; }
        public string mail { get; set; }

        public override string ToString()
        {
            return "values ('" + adsoyad +"','" + kullaniciadi + "','" + sifre + "','" + yetki + "','" + cepno + "','" + mail + "')";
        }
    }

}
