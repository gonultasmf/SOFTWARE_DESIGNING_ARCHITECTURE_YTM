using Ödevim.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevim
{
    public class Bilgilendirme
    {
        private Sms sms;
        private Mail mail;
        private Bildirim bildirim;
        private IIletisim sms1, mail1, bildirim1;
        private List<IIletisim> iletisimler;
        public Bilgilendirme()
        {
            sms = new Sms();
            mail = new Mail();
            bildirim = new Bildirim();

            sms1 = new Sms();
            mail1 = new Mail();
            bildirim1 = new Bildirim();
            iletisimler = new List<IIletisim>();
            iletisimler.Add(sms1);
            iletisimler.Add(mail1);
            iletisimler.Add(bildirim1);
        }
        public void BilgiGonder(IKullanici kullanici, string mesaj)
        {
            //    sms.smsGonder(kullanici, mesaj);              // -> Somut Kullanım DIP Prensibine Aykırı
            //    mail.mailGonder(kullanici, mesaj);            // -> Somut Kullanım DIP Prensibine Aykırı
            //    bildirim.bildirimGonder(kullanici, mesaj);    // -> Somut Kullanım DIP Prensibine Aykırı
            sms.Gonder(kullanici, mesaj);
            mail.Gonder(kullanici, mesaj);
            bildirim.Gonder(kullanici, mesaj);
        }
    }
}
