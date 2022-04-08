using Ödevim.Interface;
using System;
using System.Collections.Generic;

namespace Ödevim
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri("Sefa");
            Satici satici = new Satici("Hakan");
            Urun pc = new Urun("Bilgisayar", 16000);
            Urun tel = new Urun("Telefon", 5000);
            satici.urunEkle(pc);
            satici.urunEkle(tel);
            musteri.urunGoruntule(pc);
            satici.urunGoruntule(tel);
            Sms sms = new Sms();
            sms.Gonder(musteri, "Mesaj ile iletişim...");
            Mail mail = new Mail();
            mail.Gonder(satici, "Mail ile iletişim...");
            Bildirim bildirim = new Bildirim();
            bildirim.Gonder(satici, "Bildirim ile iletişim...");
            Console.ReadLine();
        }
    }
}
