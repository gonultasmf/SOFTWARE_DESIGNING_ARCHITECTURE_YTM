using Ödevim.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevim
{
    public class Mail : IIletisim
    {
        public void mailGonder(IKullanici kullanici, string mesaj)
        {
            Console.WriteLine("Mesaj: " + mesaj);
        }
        public void Gonder(IKullanici kullanici, string mesaj)
        {
            mailGonder(kullanici, mesaj);
        }
    }
}
