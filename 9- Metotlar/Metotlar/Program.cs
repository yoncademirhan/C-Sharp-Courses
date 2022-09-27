using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {

       

        static void Main(string[] args)
        {
            //Lenght:String ifadeler içerisinde metinin kaç karakterden oluştuğunu bulmak için kullanılır. Int türünde değer döndürür.
            string metin = "Merhaba Dünya";
            Console.WriteLine(metin + "kelimeisnin karakter uzunluğu: " + metin.Length);

            Console.WriteLine();

            //ToLower:String değişken içerinde bulunan metnin tamamını küçük harfe dönüştürmek için kullanılır.
            Console.WriteLine(metin.ToLower());
            Console.WriteLine();

            //ToUpper: String değişken içerinde bulunan metnin tamamını büyük harfe dönüştürmek için kullanılır.
            Console.WriteLine(metin.ToUpper());
            Console.WriteLine();





            Console.WriteLine();
            //Abs: Mutlak değer alır.

            Console.WriteLine("-45 sayısının mutlak değeri: " + Math.Abs(-45));
            Console.WriteLine("-98.45 sayısının mutlak değeri: " + Math.Abs(-98.45));

            Console.WriteLine();


            //min: küçük olan degeri geriye döndürür.
            Console.WriteLine("3 ile 5 sayısının küçüğü: " + Math.Min(3, 5));
            Console.WriteLine("128 ile 45.5 sayısının küçüğü: " + Math.Min(128, 45.5));
            Console.WriteLine();

            //max: büyük olan değeri geriye döçndürür.
            Console.WriteLine("3 ile 5 sayısının büyüğü: " + Math.Max(3, 5));
            Console.WriteLine("128 ile 45.5 sayısının büyüğü: " + Math.Max(128, 45.5));
            Console.WriteLine();

            //pow: sayının üs degeriniş döndürür.
            Console.WriteLine("2 nin 5. kuvveti: " + Math.Pow(2, 5));
            Console.WriteLine("5 in 5. kuvveti: " + Math.Pow(5, 5));
            Console.WriteLine();

            //round: ondalıklı sayıyı en yakın tam sayıya yuvarlar.
            Console.WriteLine("3.1 sayısının yuvarlanmış hali: " + Math.Round(3.1));
            Console.WriteLine("3.9 sayısının yuvarlanmış hali: " + Math.Round(3.9));
            Console.WriteLine();

            //sqrt: sayının karekökünü alır.
            Console.WriteLine("25 sayısının karekökü: " + Math.Sqrt(25));
            Console.WriteLine("625 sayısının karekökü: " + Math.Sqrt(625));
            Console.WriteLine();

            //Ceiling:Parametre olarak verilen ondalıklı sayıyı yukarıya veya tamsayının aynısına yuvarlamak için kullanılır. Virgülden sonra 0 girilmiş ise kendi tam sayısına daha yüksek bir değer girildiyse yukarıya yuvarlama yapar.
            Console.WriteLine("3.1 sayısının yuvarlanmış hali: " + Math.Ceiling(3.0));
            Console.WriteLine("3.9 sayısının yuvarlanmış hali: " + Math.Ceiling(3.9));
            Console.WriteLine();

            /*DivRem: Bölme işleminde bölümü bulmak için kullanılan metoddur. Bölünen ve bölen girildiğinde geriye bölme işleminin sonucunu veren ve 3. parametre olarakta kalanı veren parametredir. Sayısal veri türlerinin tamamında kullanılabilir.
            Kullanımı: Math.DivRem(<bolunen>,<bolen>,out <kalan>);*/

            Console.WriteLine("18/4 işleminde: ");
            int kalan;
            int bolum = Math.DivRem(18,4,out kalan);
            Console.WriteLine("bölüm: " + bolum);
            Console.WriteLine("kalan: " + kalan);



        }


    }
}
