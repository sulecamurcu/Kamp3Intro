using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{

    public class Personel
    {
        int MesaiSaatleri;
       
        public int mesaisaatleri
        {


            get { return MesaiSaatleri; }
            set { MesaiSaatleri = value; }

        }

        public virtual void PersonelYazdir()
        {
            Console.WriteLine($"MesaiSaatleri:{this.MesaiSaatleri}\n");
        }

       

    }

        


    }
    
    

    public class KadroluPersonel:Personel
    {
        int kadroyagecisyili;
        public int Kadroyagecisyili
        {
            get { return Kadroyagecisyili; }
            set { Kadroyagecisyili = value; }

        }
        public override void PersonelYazdir()
        {
            base.PersonelYazdir();
            Console.WriteLine($"KADROYAGECİSYİLİ:{this.kadroyagecisyili}");
        }
    }

    public class Sozlesmelipersonel:Personel
    {
        string tayintarihi;
        public string Tayintarihi
        {
            get { return Tayintarihi; }
            set { Tayintarihi = value; }
        }
    public override void PersonelYazdir()
        {
            base.PersonelYazdir();
            Console.WriteLine($"TAYİNTARİHİ:{this.tayintarihi}");
        }
    }




      
    class Program
    {
       static void Main(string[] args)

       {

       }
 
        
    }
}
