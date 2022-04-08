using Ödevim.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevim
{
    public class Sms : IIletisim
    {
        public void smsGonder(IKullanici kullanici, string mesaj, string ulkeKodu)
        {
            Console.WriteLine("Mesaj: " + mesaj);
        }
        public void Gonder(IKullanici kullanici, string mesaj)
        {
            smsGonder(kullanici, mesaj, "+90");
        }
    }
}
