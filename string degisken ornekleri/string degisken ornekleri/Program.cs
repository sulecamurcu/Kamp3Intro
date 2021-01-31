ing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_degisken_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.WriteLine("lütfen isminizi giriniz");
            ad = Console.ReadLine();
            Console.WriteLine("sayın:{0}", ad);

            string soyad;
            Console.WriteLine("lütfen soyadınızı giriniz");
            soyad = Console.ReadLine();
            Console.WriteLine("Mrs.:{0}", soyad);
            Console.ReadLine();
            int vize1, vize2, vize3, proje, ortalama;
            Console.WriteLine("birinci sınav notunu giriniz");
            vize1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sınav notunu giriniz");
            vize2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("üçüncü sınav notunu giriniz");
            vize3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("proje notunuzu giriniz");
            proje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("***Sınavların Ortalama Degeri * *");
            Console.WriteLine();
            ortalama = (vize1 + vize2 + vize3 + proje) / 4;
            Console.Write("ortalama=" + ortalama);
            Console.ReadLine();














        }
    }
}