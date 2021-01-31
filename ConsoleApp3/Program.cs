using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    namespace ConsoleApplication1
    {
        public class Personel
        {

            int maas;
            public int Maas
            {
                get { return maas; }
                set { maas = value; }
            }
            int mesaisaatleri;
            public int Mesaisaatleri

            {
                get { return mesaisaatleri; }
                set { mesaisaatleri = value; }
            }

            public void ozellikgoster()
            {
                Console.WriteLine("********PERSONEL OZELLİKLERİ*******\nmaası={0}\nmesaisaatleri={1}",maas,mesaisaatleri);
            }
        }
        class KadroluPersonel : Personel
        {

            public string egitimdurumu;
            public string Egitimdurumu
            {
                get { return egitimdurumu; }
                set { egitimdurumu = value; }
            }
            public string adres;
            public string Adres
            {
                get { return adres; }
                set { adres = value; }
            }
            public void kadrolupersonelozellik()
            {
                Console.WriteLine("\negitimdurumu={0}\nadresi={1}", egitimdurumu, adres);
            }
        }

        class sözlesmelipersonel : Personel
        {

            public int sözlesmebitis;
            public int Sözlesmebitis
            {
                get { return sözlesmebitis; }
                set { sözlesmebitis = value; }
            }
            public double telno;
            public double Telno
            {
                get { return telno; }
                set { telno = value; }
            }
            public void sozlesmelipersonelozellik()
            {
                Console.WriteLine("\nsözlesmebitis={0}\ntelno={1}", sözlesmebitis, telno);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                KadroluPersonel kisil = new KadroluPersonel();
                kisil.Maas = 5690;
                kisil.Mesaisaatleri = 10;
                kisil.Egitimdurumu = "Universite Mezunu";
                kisil.Adres = "OsmangaziBursa";
                kisil.ozellikgoster();
                kisil.kadrolupersonelozellik();



                sözlesmelipersonel kisi2 = new sözlesmelipersonel();
                kisi2.Maas = 4690;
                kisi2.Mesaisaatleri = 10;
                kisi2.Sözlesmebitis = 2;
                kisi2.Telno = 1234567;
                kisi2.ozellikgoster();
                kisi2.sozlesmelipersonelozellik();
                Console.ReadKey();
            }
            


        }
    }
}
