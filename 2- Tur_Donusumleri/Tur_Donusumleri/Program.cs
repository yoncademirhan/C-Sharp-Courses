using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tür Dönüşümleri
            /*
             * Kullanıcıdan alınan değerlerde veya dönüştürmek istediğiniz değerleri Convert sınıfı aracılığı ile veya dönüştürmek istediğiniz veri tipinin içerisinde bulunan Parse() metodu ile tür dönüşümü işlemini sağlayabilirsiniz.
             *
             * Bir metinsel değeri tam sayıyı çevirmek için:
             * 1- Convert.ToInt32(<deger>);
             * 2- int.Parse(<değer>);
             *
             */

            // Veri tiplerine göre tür dönüşüm metodları (Convert):
            /*
             * Convert.ToInt32(<deger>); int a çevirmek için
             * Convert.ToInt64(<deger>); long a çevirmek için
             * Convert.ToDouble(<deger>); double a çevirmek için
             * Convert.ToSingle(<deger>); float a çevirmek için
             * Convert.ToDecimal(<deger>); decimal e çevirmek için
             * Convert.ToBool(<deger>); boolean a çevirmek için
             * Convert.ToChar(<deger>); char a çevirmek için
             *
             *
             */

            /*
             * Veri tiplerine göre tür dönüşüm metodları (veritipi):
             *
             * int.Parse(<deger>); int a çevirmek için
             * double.Parse(<deger>); double a çevirmek için
             * float.Parse(<deger>); float a çevirmek için
             * decimal.Parse(<deger>); decimal a çevirmek için
             * .......
             */

            // Tür dönüşümü metodları veriyi hangi tipe dönüştürürseniz o tipteki değeri size geri verir.

            string metin = Console.ReadLine();
            int sayi1 = int.Parse(metin);
            int sayi2 = Convert.ToInt32("15");
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);

            Console.ReadKey();
        }
    }
}
