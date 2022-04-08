using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Hazirlik_1
{
    class Mudur : IMudurIslem
    {
        public string KayitEkle()
        {
            return "Kayıt Ekleme Başarılı";
        }

        public string KayitGuncelle()
        {
            return "Kayıt Güncellem Başarılı";
        }

        public string KayitSil()
        {
            return "Kayıt Sil Başarılı";
        }
    }
}
