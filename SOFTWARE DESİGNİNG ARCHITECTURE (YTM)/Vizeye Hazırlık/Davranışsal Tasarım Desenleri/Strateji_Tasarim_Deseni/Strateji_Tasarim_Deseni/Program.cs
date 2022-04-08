using System;

namespace Strateji_Tasarim_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strateji");
            Duzen standart = new Standart();
            Duzen yilbasi = new YilBasi();
            Duzen haftasonu = new HaftaSonu();

            Magaza magaza = new Magaza();
            magaza.MyDuzen = standart;
            magaza.FiyatHesapla(10);
            magaza.TasarimiGoster();

            magaza.MyDuzen = yilbasi;
            magaza.FiyatHesapla(10);
            magaza.TasarimiGoster();

            magaza.MyDuzen = haftasonu;
            magaza.FiyatHesapla(10);
            magaza.TasarimiGoster();
        }
    }
}

public interface Duzen
{
    double FiyatHesapla(double fiyat);
    String TasarimiGetir();
}
class Standart : Duzen
{
    public double FiyatHesapla(double fiyat)
    {
        return fiyat;
    }

    public String TasarimiGetir()
    {
        return "Standart";
    }  
}
class YilBasi : Duzen
{
    public double FiyatHesapla(double fiyat)
    {
        return fiyat * 0.5;
    }

    public String TasarimiGetir()
    {
        return "Yılbaşı";
    }  
}
class HaftaSonu : Duzen
{
    public double FiyatHesapla(double fiyat)
    {
        return fiyat * 0.7;
    }

    public String TasarimiGetir()
    {
        return "Haftasonu";
    }  
} 
class Magaza
{
    private Duzen myDuzen;
    public Duzen MyDuzen
    {
        get
        {
            return myDuzen;
        }
        set
        {
            myDuzen = value;
        }
    }
    public void FiyatHesapla(double fiyat)
    {
        Console.WriteLine(myDuzen.FiyatHesapla(fiyat));
    }
    public void TasarimiGoster()
    {
        Console.WriteLine(myDuzen.TasarimiGetir());
    }

}
