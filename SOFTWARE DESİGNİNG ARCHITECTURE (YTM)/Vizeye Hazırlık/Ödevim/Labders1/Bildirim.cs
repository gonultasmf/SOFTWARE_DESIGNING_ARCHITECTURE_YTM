using Ödevim.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevim
{
    public class Bildirim : IIletisim
    {
        public void bildirimGonder(IKullanici kullanici, string mesaj)
        {
            Console.WriteLine("Mesaj: " + mesaj);
        }
        public void Gonder(IKullanici kullanici, string mesaj)
        {
            bildirimGonder(kullanici, mesaj);
        }
    }
}
