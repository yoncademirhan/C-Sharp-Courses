using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Try-Catch (Hata Kontrol Mekanizması)
            /*
             * Yazmış olduğumuz kod bloklarında hataların önüne geçmek için kullanılan bir yapıdır. Hatalatın önüne geçmekten kasıt hataların önlenmesini değil, mevcut oluşabilecek potansiyel hataları yakalayıp uygulamaya hata verdirmemektir.
             *
             * Try-Catch mekaniması kaba tanımı ile potansiyel hata oluşabilecek satırda oluşan hataları yakalayıp kullanıcı yönlendirmektir.
             *
             * Syntax
             * try {
             *
             * }
             * catch (Exception <exceptionAdi>){
             *
             * }
             *
             * try => tükçe karşılığı dene manasına gelir. Hata oluşabilecek komut satırları bu alanda yazılır.
             *
             * catch => türkçe karşılığı yakala manasına gelir. Try içerisinde yazılan komut satırı veya satırlarında bir hata oluşursa otomatik olarak bu blok içerisine girer ve bu alandaki kout satırlarını işleme alır.
             *
             * Exception => Try bloğu içerisinde hata oluştuğunda neden, ne için hata oluştuğunun bilgisinni tutulduğu özel bir sınıftır. Bu sınıf ieçrisinde bulunan Message property'si ile hata mesajına ulaşabilirsiniz.
             *
             *
             * Örnek
             * ----------------
             */

            int sayi = 0;
            try
            {
                sayi = int.Parse("abc");
                Console.WriteLine("Sayı: " + sayi);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }

            Console.ReadKey();
        }
    }
}
