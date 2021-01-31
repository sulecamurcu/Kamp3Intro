using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetMenagar
    {
       // naming convention-isimlendirme kuralı
       //syntax- yazım sekilleri
       public void Ekle(Urun urun) //Bu bir imzadır.metot bir parametre alıyor o parametrenin tipi "Urun" urunun adını da aşağıdaki sekilde yazdırıyorum.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi:"+urun.Adi);
        }


    }
}
