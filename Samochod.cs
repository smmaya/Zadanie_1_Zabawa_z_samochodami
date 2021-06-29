using System;

namespace Zadanie_1
{
    public class Samochod
    {
        private string marka, model;
        private int ilosc_drzwi;
        private double pojemnosc_silnika, srednie_spalanie;
        private static int ilosc_samochodow = 0;

        public Samochod()
        {
            marka = "nieznana marka";
            model = "nieznany model";
            ilosc_drzwi = 0;
            pojemnosc_silnika = 0.0;
            srednie_spalanie = 0.0;
        }

        public Samochod(string _marka, string _model, int _ile_drzwi, double _pojemnosc_silnika, double _srednie_spalanie)
        {
            marka = _marka;
            model = _model;
            ilosc_drzwi = _ile_drzwi;
            pojemnosc_silnika = _pojemnosc_silnika;
            srednie_spalanie = _srednie_spalanie;
            ilosc_samochodow = ilosc_samochodow + 1;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (srednie_spalanie * dlugoscTrasy) / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double x = ObliczSpalanie(dlugoscTrasy);
            return x * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilość drzwi: " + ilosc_drzwi);
            Console.WriteLine("Pojemność silnika: " + pojemnosc_silnika);
            Console.WriteLine("Średnie spalanie: " + srednie_spalanie + "\n");
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Ilość Samochodów: " + ilosc_samochodow);
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Ile_drzwi
        {
            get { return ilosc_drzwi; }
            set { ilosc_drzwi = value; }
        }

        public double Srednie_spalanie
        {
            get { return srednie_spalanie; }
            set { srednie_spalanie = value; }
        }

        public double Pojemnosc_silnika
        {
            get { return pojemnosc_silnika; }
            set { pojemnosc_silnika = value; }
        }

    }
}

    //public class Samochod
    //{
    //    public string marka { get; set; }
    //    public string model { get; set; }
    //    public int iloscdrzwi { get; set; }
    //    public int pojsilnika { get; set; }
    //    public double sredniespalanie { get; set; }
    //    private static int count = 0;

    //    public Samochod()
    //    {
    //        marka = "jeszcze nic";
    //        model = "też nic";
    //        iloscdrzwi = 0;
    //        pojsilnika = 0;
    //        sredniespalanie = 0.0;
    //        count += 1;
    //    }

    //    public Samochod(string a, string b, int c, int d, double e)
    //    {
    //        marka = a;
    //        model = b;
    //        iloscdrzwi = c;
    //        pojsilnika = d;
    //        sredniespalanie = e;
    //        count +=1;
    //    }

    //    public static int getCount()
    //    {
    //        return count;
    //    }

    //    public double ObliczSpalanie(double dlugosctrasy)
    //    {
    //        return (sredniespalanie * dlugosctrasy) / 100;
    //    }

    //    public double ObliczKosztPrzejazdu(double cenaPaliwa)
    //    {
    //        return ObliczSpalanie(500) * cenaPaliwa;
    //    }


    //}

//}
