using Ödevim.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevim
{
    public class Musteri : IKullanici, IGiris
    {
        private string isim;
        public Musteri(string isim)
        {
            setIsim(isim);
        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }
        public string getIsim() { return isim; }
        public void girisYap()
        {
            Console.WriteLine(getIsim() + " Giriş Yaptı");
        }
        public void urunGoruntule(Urun urun)
        {
            Console.WriteLine(getIsim() + " müşterisi " + urun.getIsim() + " ürününe baktı");
        }
    }
}
