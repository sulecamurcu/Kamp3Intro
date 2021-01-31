using System;

namespace _1.eğitim
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.Write("BİRİNCİ SAYIYI GİRİNİZ:");
           a = Convert.ToDouble(Console.ReadLine());
            Console.Write("İKİNCİ SAYİYİ GİRİNİZ:");
             b = Convert.ToDouble(Console.ReadLine());
            Console.Write("ÜÇÜNCÜ SAYİYİ GİRİNİZ:");
            c = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine($"toplam:{a+b+c}");
            Console.ReadKey();



        }
    }  
}
