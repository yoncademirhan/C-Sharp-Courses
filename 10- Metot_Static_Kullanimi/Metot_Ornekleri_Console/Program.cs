using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Ornekleri_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int sonuc = metotlar.topla(5, 8);
            Console.WriteLine(sonuc);*/

            //static olmadıgı zaman metodun bulundugu sınıftan nesne üretmemiz gerekir.

            metotlar metot1 = new metotlar();    //metot1 nesnesi metotlar sınıfındaki tüm özellikleri taşır.;
            int sonuc = metot1.topla(5, 8);
            Console.WriteLine(sonuc);


            Console.ReadKey();

        }


        class metotlar
        {
            public /*static*/ int topla(int s1, int s2)       //erişim sağlanması için public olarak belirtildi. geriye döndürülecek deger int olarak belirlendi.
                                                          // static ile metod ismi yazıldıgı anda gerekli parametreleri göndererek çalıştırılmasını sağlar.
            {
                return (s1 + s2);
            }
        }
    }
}
