using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevim.Interface
{
    public interface IIletisim
    {
        void Gonder(IKullanici kullanici, string mesaj);
    }
}
