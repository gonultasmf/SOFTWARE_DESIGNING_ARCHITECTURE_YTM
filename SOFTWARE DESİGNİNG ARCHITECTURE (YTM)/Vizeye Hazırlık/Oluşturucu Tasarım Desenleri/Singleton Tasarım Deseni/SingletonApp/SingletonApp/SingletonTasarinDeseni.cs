using System;

namespace SingletonApp
{
    class SingletonTasarimDeseni
    {
        static void Main(string[] args)
        {

            // SignletonDeseni desen = new SignletonDeseni(); 
            // Yapıcı methodu private yaparak tekrardan nesne oluşturulmasına 
            // engel olduk.

            // SignletonDeseni nesne = SignletonDeseni.Nesne;
            // Üst satırdaki gibi nesnemize "özellik" üzerinden ulaşabiliriz.

            // SignletonDeseni nesne = SignletonDeseni.Nesnem();
            // Üst satırdaki gibi nesnemize "method" üzerinden ulaşabiliriz.

            SignletonDeseni nesne1 = SignletonDeseni.Nesnem();
            SignletonDeseni nesne2 = SignletonDeseni.Nesnem();

            if (nesne1 == nesne2)
                Console.WriteLine("İki nesne de aynı....");
            else
                Console.WriteLine("İki nesne de farklı....");
        }
    }

    public class SignletonDeseni
    {
        // SingletonDeseni sınıfı belleğe yüklendiği anda 
        // alt satırdaki nesne yaratılacaktır.
        private static SignletonDeseni nesne = new SignletonDeseni();

        private SignletonDeseni() 
        {
            // private kullandık ki yapıcı methoda
            // dışardan erişim olmasın

            Console.WriteLine("Yapıcı Method çalıştı...");
        }

        public static SignletonDeseni Nesne // Özellik üzerinden 
        {                                   // nesneye erişme.
            get
            {
                return nesne;
            }
            // burada set bloğu açmadık 
            // çünkü oluşturulan nesnenin çalışma zamanı içinde 
            // değiştirilmesini istemedik.
        }

        public static SignletonDeseni Nesnem() // Metod üzerinden
        {                                      // nesneye erişme.
            return nesne;
        }
    }

    // Yukardaki SingletonDeseni sınıfında sınıfı belleğe yüklediği anda 
    // nesne oluşturuyordu.
    // Eğer ki bunu istemiyorsak:

    public class Signleton
    {
        // Sınıf belleğe yüklense bile nesne oluşturulmadı.
        private static Signleton nesne;

        private Signleton() // Yapıcı methodu erişime kapattık.
        {
            Console.WriteLine("Yapıcı Method çalıştı...");
        }

        public static Signleton Nesnem()
        {
            // Daha önce nesne oluşturulmadıysa oluşturacaktır.
            // yani sınıf belleğe yüklendiği gibi değil de
            // nesne oluşturulmak istediğinde kontrolden geçerek 
            // oluşturalacktır.
            if (nesne == null)
                nesne = new Signleton();
            return nesne;
        }
        // methodla yaptık ama özellikle de yapılabilir bu
        // aynı şey zaten
    }

    // Her şeye rağmen Signleton sınıfında bazı durumlar için
    // tek bir nesnenin oluşmasını garanti etmemiş olabiliriz.

    // Kilitleme yöntemi ile yapmak çoklu kullanıcılı sistemlerde 
    // signleton desenine çok daha uygun olur.

    public class SignletonPattern
    {
        private static SignletonPattern nesne;
        private static Object kanalKontrol = new Object();

        private SignletonPattern() // yapıcı methodu erişime kapattık.
        {
            Console.WriteLine("Yapıcı Method çalıştı...");
        }
        public static SignletonPattern Nesnem()
        {
            if (nesne == null) // nesne önceden oluşmamışsa diye kontrol edilir.
            {
                lock (kanalKontrol) // içerisindeki işlemler bitmeden diğer işlemler
                {                   // yapılamaz. Kilitleme yapıyor. tekrar çalışmaz.
                                    // içerdeki işlem bitmeden.
                    if (nesne == null) // Buradaki nesne kontrolün amacı ise 
                    {                  // ilk kontrolden geçen istemcinin ( yani 
                                       // daha önceden aynı anda gelen ikinci 
                                       // istemcinin nesne var ise tekrar oluşmasını 
                                       // engellemektir.
                        nesne = new SignletonPattern(); // nesne oluşturuldu.
                    }
                }
            }
            return nesne;
        }
    }
}
