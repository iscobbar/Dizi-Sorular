using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dizi_Sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
        // SORU1: 5 Elemanlı bir sınıfta her öğrenci için aşağıdaki bilgileri klavyeden isteyip dizide saklayınız.
        // * Ad
        // * Numara
        // * DoğumYılı

        //CEVAP1: 1.Yöntem: Tek Dizi
            string[] bilgiler = new string[15];

            for (int i = 0; i <= 14; i = i + 3)
            {
                Console.Write("Ad Giriniz: ");
                bilgiler[i] = Console.ReadLine();

                Console.Write("Numara Giriniz: ");
                bilgiler[i + 1] = Console.ReadLine();

                Console.Write("Doğum Yılı Giriniz: ");
                bilgiler[i + 2] = Console.ReadLine();
            }

            Console.WriteLine("\"Bilgi Listesi\" \n"); // \n alt satıra atlatmak için kullanılır. (Escape characters)
            Console.WriteLine("----------");


            for (int i = 0; i <= 14; i += 3)
            {
                Console.WriteLine($"Ad: {bilgiler[i]}");
                Console.WriteLine($"Numara: {bilgiler[i + 1]}");
                Console.WriteLine($"Doğum Yılı: {bilgiler[i + 2]}");
                Console.WriteLine("----------");
            }


            // CEVAP1: Yöntem 2
            string[] isimler = new string[5];
            string[] numaralar = new string[5];
            string[] dogumyillari = new string[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Ad Giriniz: ");
                isimler[i] = Console.ReadLine();

                Console.Write("Numara Giriniz: ");
                numaralar[i] = Console.ReadLine();

                Console.Write("Doğum Yılı Giriniz: ");
                dogumyillari[i] = Console.ReadLine();
            }

            Console.WriteLine("\"Bilgi Listesi\" \n"); // \n alt satıra atlatmak için kullanılır. (Escape characters)
            Console.WriteLine("----------");


            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Ad: {isimler[i]}");
                Console.WriteLine($"Numara: {numaralar[i]}");
                Console.WriteLine($"Doğum Yılı: {dogumyillari[i]}");
                Console.WriteLine("----------");
            }


            // SORU2: 15 elemanlı bir dizi tanımlayın. 1-100 arasında rastgele sayı üretip
            // dizi elemanlarına atayın. Daha sonra dizinin elemanlarından teklerin ve çiftlerin toplamını bulun. 
            //Kaç tek kaç çift eleman var ekrana yazdırın.

            int[] sayilar = new int[15];
            Random rs = new Random();
            int tekTop = 0;
            int ciftTop = 0;
            int sayacTek = 0;
            int sayacCift = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Thread.Sleep(522);
                sayilar[i] = rs.Next(100);
                Console.WriteLine(sayilar[i]);

                if (sayilar[i] % 2 == 0)
                {
                    sayacCift++;
                    ciftTop += sayilar[i];
                }
                else
                {
                    sayacTek++;
                    tekTop += sayilar[i];
                }
            }

            Console.WriteLine("Teklerin toplamı");
            Console.WriteLine(tekTop);
            Console.WriteLine("Teklerin Sayısı");
            Console.WriteLine(sayacTek);

            Console.WriteLine("ciftlerin toplamı");

            Console.WriteLine(ciftTop);
            Console.WriteLine("ciftlerin sayısı");
            Console.WriteLine(sayacCift);

            Console.Read();


        }
    }
}