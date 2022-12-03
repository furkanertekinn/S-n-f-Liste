using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerOrnekUygulamalar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıf Öğrenci Listesi :");
            Console.WriteLine("-----------------------");

            string[] ogrenciListesi = new string[5];

            ogrenciListesi[0] = "* Furkan ERTEKİN";
            ogrenciListesi[1] = "* Emre ÖZTÜRK";
            ogrenciListesi[2] = "* Mert KAZANCI";
            ogrenciListesi[3] = "* Yasin ÇAĞLAR";
            ogrenciListesi[4] = "* Göktuğ ERDEM";

            foreach(string item in ogrenciListesi)
            {
                Console.WriteLine(item) ;
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Okul Numarasına Göre Sınıf Öğrenci Listesi :");
            Console.WriteLine("--------------------------------------------");

            string[] okulNumarasi = new string[5];

            okulNumarasi[0] = "Emre Öztürk / 1907";
            okulNumarasi[1] = "Yasin Çağlar / 1904";
            okulNumarasi[2] = "Göktuğ ERDEM / 1901";
            okulNumarasi[3] = "Furkan ERTEKİN / 1899";
            okulNumarasi[4] = "Mert KAZANCI / 1895";


            for (int i = 0; i < okulNumarasi.Length; i++)
            {
                string ogrenciGelenNumara = okulNumarasi[i];
                Console.WriteLine(ogrenciGelenNumara);
            }
            Console.ReadLine();

        }
    }
}
