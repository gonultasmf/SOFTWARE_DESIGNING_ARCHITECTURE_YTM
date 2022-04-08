using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevim
{
    public class Urun
    {
        private string isim;
        private int fiyat;
        public Urun(string _isim, int _fiyat)
        {
            setIsim(_isim);
            setFiyat(_fiyat);

        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }
        public string getIsim() { return isim; }
        public void setFiyat(int fiyat)
        {
            this.fiyat = fiyat;
        }
        public int getFiyat() { return fiyat; }
    }
}
