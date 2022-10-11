using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Constructor: Nesne yönelimli programlama kavramı içerisinde bulunan sınıf yapılarını nesne oalrk tanımlanmasında alt yapıyı
            hazırlayan, kurucu rolü üstlenen, sınıf ile aynı isme sahip olan geriye deger döndürmeyen fonksiyon türüdür.

            * Yalnızca sınıf cagırma esnasında new ifadesi ile birlikte çalışır.sonradan cagırma imkanınız yoktur.
            
            * Constructor metod ismi class ismi ile aynı olmak zorundadır.
            
            * Geriye deger döndürmedikleri için void yapıda tanımlanmalıdır.
            
            * Erişim belirleyici mutlaka public olmalıdır.Aksi takdirde Constructor metot olarak işlevi gerçekleştiremez.
             
             */


            Araba a1= new Araba();
            a1.Marka = "BMW";
            a1.Model = "X5";
            a1.Renk = "Siyah";

            a1.Yazdir();

            Console.WriteLine();

            Araba a2 = new Araba("Audi", "A6", "Beyaz");
            a2.Yazdir();









            Console.ReadKey();



        }
    }
}
