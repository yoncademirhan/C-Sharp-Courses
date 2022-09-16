using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While döngüsü içerisindeki koşul dogru(true) oldugu sürece tekrar eder. Koşul yanlış oldugunda döngüden cıkılır.
            //Bir kontrol ifadesiyle döngünün devam edilip edilmeyeceği kontrol edilirken, scope içinde ( yani ayraç işaretleri arasında ) kalan bütün alan işleme sokulur.
            //İşleme sokulan kod kısmı döngü yapılacak adet kadar tekrar eder.


            //Örnek: 1 den 10 a kadar sayıları ekrana yazdırınız.
            //Çözüm: 

            int sayac1 = 1;
            int hedef1 = 10;

            while (sayac1 <= hedef1)
            {
                Console.Write(sayac1+ " ");
                sayac1++;
            }


            //Örnek: 1 ile 100 arasındaki sayıların toplamını ekrana yazdıralım.


            int sayac = 1;
            int hedef = 100;
            int toplam1 = 0;

            while(sayac <= hedef)
            {
                toplam1 += sayac;
                sayac++;
            }

            Console.WriteLine("Sayıların toplamı: " + toplam1 ); 



            //Örnek: Klavyeden çift sayı girildiği sürece sayıları toplayan , tek sayı girildiğinde döngüyü sonlandıran ve yoplam sonucu ekrana yazan bir uygulama yazalım.
            //Çözüm:

            int sayi = 0, toplam = 0;

            while(sayi % 2 == 0)
            {
                toplam += sayi;
                Console.Write("Bir sayı giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }

            Console.WriteLine("SAyıların Toplamı:" + toplam);







            Console.ReadKey();
        }
    }
}
