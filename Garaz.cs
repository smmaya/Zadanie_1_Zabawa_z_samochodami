using System;

namespace Zadanie_1
{
    class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set { pojemnosc = value; samochody = new Samochod[pojemnosc]; }
        }

        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Garaz(string _adres, int _pojemnosc)
        {
            adres = _adres;
            pojemnosc = _pojemnosc;
            samochody = new Samochod[_pojemnosc];
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if (pojemnosc == liczbaSamochodow)
            {
                Console.WriteLine("Nie mam miejsca w garażu");
            }

            else
            {
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow++;
            }
        }

        public Samochod WyprowadzSamochod()
        {
            if (liczbaSamochodow == 0)
            {
                Console.WriteLine("Są miejsca w garażu");
            }

            else
            {
                liczbaSamochodow--;
                samochody[liczbaSamochodow] = null;
            }
            return samochody[liczbaSamochodow];
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Adres garażu: " + adres);
            Console.WriteLine("Pojemność garażu: " + pojemnosc);
            Console.WriteLine("Liczba samochodów w garażu: " + liczbaSamochodow + "\n");

            for (int i = 0; i < liczbaSamochodow; i++)
            {
                samochody[i].WypiszInfo();
            }
        }
    }
}
    //public class Garaz
    //{
    //    public string adres;
    //    public int pojemnosc;
    //    public int liczbaSamochodow = 0;
    //    public Samochod[] samochody;
    //    public string Adres { get => adres; set { adres = value; } }
    //    public int Pojemnosc { get => pojemnosc; set { pojemnosc = value; samochody = new Samochod[pojemnosc]; } }

    //    public Garaz()
    //    {
    //        adres = "Nieznany";
    //        pojemnosc = 0;
    //    }

    //    public Garaz(string adres, int pojemnosc)
    //    {
    //        this.adres = adres;
    //        this.pojemnosc = pojemnosc;
    //        samochody = new Samochod[Pojemnosc];
    //    }
    //    public void WprowadzSamochod(Samochod samochod)
    //    {
    //        if (pojemnosc == liczbaSamochodow)
    //        {
    //            Console.WriteLine("Garaż jest pełny");
    //        }
    //        else
    //        {
    //            samochody[liczbaSamochodow] = samochod;
    //            liczbaSamochodow++;
    //        }
    //    }
    //    public Samochod WyprowadzSamochod()
    //    {
    //        if (liczbaSamochodow == 0)
    //        {
    //            Console.WriteLine("Garaż jest pusty");
    //        }
    //        else
    //        {
    //            liczbaSamochodow--;
    //            samochody[liczbaSamochodow] = null;
    //        }
    //        return samochody[liczbaSamochodow];
    //    }
    //    public void WypiszInfo()
    //    {
    //        Console.WriteLine("Adres garażu: " + adres);
    //        Console.WriteLine("Pojemność garażu: " + pojemnosc);
    //        Console.WriteLine("Liczba samochodów w garażu: " + liczbaSamochodow);
    //        for (int i = 0; i < liczbaSamochodow; i++)
    //        {
    //            samochody[i].WypiszInfo();
    //        }
    //    }
    //}
//}