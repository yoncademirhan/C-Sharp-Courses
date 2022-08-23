using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220607_3_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan Doğum Tarihi bilgisi talep edelim. Doğum tarihi girilen kişinin Yaşını, Bu zamana kadar kaç gün ve kaç saat yaşadığını ekrana yazdıralım.

            Console.Write("Doğum tarihinizi giriniz: ");
            DateTime tarih = DateTime.Parse(Console.ReadLine());
            TimeSpan fark = DateTime.Now.Subtract(tarih);

            Console.WriteLine();
            Console.WriteLine("Yaşınız: " + fark.Days / 365);
            Console.WriteLine("Şuana kadar " + fark.TotalDays + " gün, " + fark.TotalHours + " saat yaşamışsınız.");

            Console.ReadKey();
        }
    }
}
