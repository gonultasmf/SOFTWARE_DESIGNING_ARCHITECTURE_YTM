using System;

namespace Facade_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade Tasarım Deseni");



            FacadeEvSistemi facade = new FacadeEvSistemi();
            facade.KapiKilitAc();
            facade.KapiKilitle();
            facade.KlimaAc();
            facade.KlimaGuncelle(25);
        }
    }
}
