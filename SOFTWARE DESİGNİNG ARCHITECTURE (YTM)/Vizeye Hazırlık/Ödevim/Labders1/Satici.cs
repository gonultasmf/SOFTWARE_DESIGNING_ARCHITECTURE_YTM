using Ödevim.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevim
{
    public class Satici : IKullanici, ISatisYapilabilen, IGiris
    {
        private string isim;
        public Satici(string isim)
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
        public void urunEkle(Urun urun)
        {
            Console.WriteLine(getIsim() + " satıcısı " + urun.getIsim() + " ürününü ekledi");
        }

        public void urunGoruntule(Urun urun)
        {
            Console.WriteLine(getIsim() + " satıcısı " + urun.getIsim() + " ürününe baktı");
        }
    }
}
