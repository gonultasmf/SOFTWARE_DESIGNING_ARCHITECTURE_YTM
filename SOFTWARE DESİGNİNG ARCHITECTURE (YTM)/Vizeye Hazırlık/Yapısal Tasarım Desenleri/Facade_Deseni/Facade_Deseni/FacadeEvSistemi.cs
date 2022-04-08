using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Deseni
{
    class FacadeEvSistemi
    {
        Isik isik;
        Televizyon televizyon;
        Klima klima;
        Kapi kapi;

        public FacadeEvSistemi()
        {
            isik = new Isik(0);
            televizyon = new Televizyon();
            klima = new Klima();
            kapi = new Kapi();
        }
        public void KlimaGuncelle(int value)
        {
            klima.Guncelle(value);
        }
        public void KlimaAc()
        {
            klima.Ac();
        }
        public void KlimaKapat()
        {
            klima.Kapat();
        }
        public void KapiKilitle()
        {
            kapi.Kilitle();
        }
        public void KapiKilitAc()
        {
            kapi.KilitAc();
        }
        public void IsikAc(int value)
        {
            isik.Ac(value);
        }
        public void IsikKapat(int value)
        {
            isik.Kapat(value);
        }
        public void TVAc()
        {
            televizyon.Ac();
        }
        public void TVKapat()
        {
            televizyon.Kapat();
        }
        public void TVSesAzalt()
        {
            televizyon.sesAzalt();
        }
        public void TVSesArttir()
        {
            televizyon.sesArttir();
        }
        public void TVKanalAzalt()
        {
            televizyon.kanalAzalt();
        }
        public void TVKanalArttir()
        {
            televizyon.kanalArttir();
        }
    }
}
