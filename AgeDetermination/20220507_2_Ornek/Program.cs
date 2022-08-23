using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220507_2_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 tarih bilgisi girmesini isteyelim.
            // Girilen tarihler arasındaki gün farkını ekrana yazdıralım.

            Console.Write("1. Tarih bilgisini giriniz: ");
            DateTime tarih1 = DateTime.Parse(Console.ReadLine());

            Console.Write("2. Tarih bilgisini giriniz: ");
            DateTime tarih2 = DateTime.Parse(Console.ReadLine());

            TimeSpan fark = tarih1.Subtract(tarih2);
            Console.WriteLine("Gün Farkı: " + fark.TotalDays);

            Console.ReadKey();
        }
    }
}
