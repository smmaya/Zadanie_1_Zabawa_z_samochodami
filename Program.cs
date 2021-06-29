using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod("BMW", "320TD", 3, 800, 6.0);
            Samochod s2 = new Samochod("Moskvitch", "412", 5, 400, 9.5);
            Garaz g1 = new Garaz();
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;
            Garaz g2 = new Garaz("ul. Garażowa 2", 2);
            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();
            g2.WyprowadzSamochod();
            g2.WypiszInfo();
            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();
            Console.ReadKey();
        }
    }
}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("---");
    //        Samochod S1 = new Samochod();
    //        S1.WypiszInfo();
    //        Console.WriteLine("Marka: " + S1.marka);
    //        Console.WriteLine("Model: " + S1.model);
    //        Console.WriteLine("Ilość drzwi: " + S1.iloscdrzwi);
    //        Console.WriteLine("Pojemność silnika: " + S1.pojsilnika);
    //        Console.WriteLine("Średnie spalanie: " + S1.sredniespalanie + " l/100 km");
    //        Console.WriteLine("Zużycie paliwa: " + S1.ObliczSpalanie(500) + " l");
    //        Console.WriteLine("Koszt przejazdu: " + Math.Round(S1.ObliczKosztPrzejazdu(4.31), 2) + " zł");
    //        Console.WriteLine("Liczba samochodów: " + Samochod.getCount() + "\n");

    //        Samochod S2 = new Samochod("BMW", "Seria 3", 3, 2000, 6.5);
    //        Console.WriteLine("Marka: " + S2.marka);
    //        Console.WriteLine("Model: " + S2.model);
    //        Console.WriteLine("Ilość drzwi: " + S2.iloscdrzwi);
    //        Console.WriteLine("Pojemność silnika: " + S2.pojsilnika);
    //        Console.WriteLine("Średnie spalanie: " + S2.sredniespalanie + " l/100 km");
    //        Console.WriteLine("Zużycie paliwa: " + S2.ObliczSpalanie(500) + " l");
    //        Console.WriteLine("Koszt przejazdu: " + Math.Round(S2.ObliczKosztPrzejazdu(4.31), 2) + " zł");
    //        Console.WriteLine("Liczba samochodów: " + Samochod.getCount() + "\n");

    //        Samochod S3 = new Samochod("Syrena", "S 205", 5, 1200, 7.5);
    //        Console.WriteLine("Marka: " + S3.marka);
    //        Console.WriteLine("Model: " + S3.model);
    //        Console.WriteLine("Ilość drzwi: " + S3.iloscdrzwi);
    //        Console.WriteLine("Pojemność silnika: " + S3.pojsilnika);
    //        Console.WriteLine("Średnie spalanie: " + S3.sredniespalanie + " l/100 km");
    //        Console.WriteLine("Zużycie paliwa: " + S3.ObliczSpalanie(500) + " l");
    //        Console.WriteLine("Koszt przejazdu: " + Math.Round(S3.ObliczKosztPrzejazdu(4.31), 2) + " zł");
    //        Console.WriteLine("Liczba samochodów: " + Samochod.getCount() + "\n");

    //        Samochod S4 = new Samochod("Posche", "Carrera 911", 3, 5000, 10);
    //        Console.WriteLine("Marka: " + S4.marka + ", " + "Model: " + S4.model + ", " + "Drzwiowy: " + S4.iloscdrzwi + ", " + "Pojemność: " + S4.pojsilnika + ", " + "Spalanie: " + S4.sredniespalanie);
    //        Console.WriteLine("Zużycie paliwa: " + S4.ObliczSpalanie(500) + " l");
    //        Console.WriteLine("Koszt przejazdu: " + Math.Round(S4.ObliczKosztPrzejazdu(4.31), 2) + " zł");
    //        Console.WriteLine("Liczba samochodów: " + Samochod.getCount() + "\n");
    //    }

    //}
//}
