using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# programlama dilinde hazır metodlar içinde matematiksel metodlar bulunmaktadır. Bu metodlar Math sınıfını kullanmaktadır. Matematiksel metodlar bazı işlemleri daha kısa sürede ve kolayca yapabilmek için tasarlanmıştır.

            // Metodlardan bazıları:

            #region Abs()

            // Verilen sayının mutlak değerini almak için kullanılır. Abs metodu parametre olarak tüm sayısal veri türlerini alabilmektedir.
            // Kullanımı: Math.Abs(<deger>);

            Console.WriteLine("Abs()");
            Console.WriteLine("-------------------");

            Console.WriteLine("-45 sayısının mutlak değeri: " + Math.Abs(-45));
            Console.WriteLine("-95.78 sayısının mutlak değeri: " + Math.Abs(-95.78));

            Console.WriteLine();
            #endregion

            #region Min()

            // parametre olarak verilen iki sayıdan küçük olanını geriye döndürür.
            // Kullanımı: Math.Min(<deger1>,<deger2>);

            Console.WriteLine("Min()");
            Console.WriteLine("-------------------");

            Console.WriteLine("3 ile 5 sayısının küçüğü: " + Math.Min(3, 5));
            Console.WriteLine("128 ile 45.8 sayısının küçüğü: " + Math.Min(128, 45.8));

            Console.WriteLine();
            #endregion

            #region Max()

            // parametre olarak verilen iki sayıdan büyük olanını geriye döndürür.
            // Kullanımı: Math.Max(<deger1>,<deger2>);

            Console.WriteLine("Max()");
            Console.WriteLine("-------------------");

            Console.WriteLine("3 ile 5 sayısının büyüğü: " + Math.Max(3, 5));
            Console.WriteLine("128 ile 45.8 sayısının büyüğü: " + Math.Max(128, 45.8));

            Console.WriteLine();
            #endregion

            #region Pow()

            // Üs alma metodudur. Parametre olarak verilen birinsi sayının parametre olarak verilen ikinci sayı kadar çarpımını hesaplamak için kullanılır.
            // Kullanımı: Math.Pow(<deger1>,<deger2>);

            Console.WriteLine("Pow()");
            Console.WriteLine("-------------------");
            Console.WriteLine("2 nin 5'e kuvveti: " + Math.Pow(2, 5));
            Console.WriteLine("5 nin 5'e kuvveti: " + Math.Pow(5, 5));

            Console.WriteLine();
            #endregion

            #region Round()

            // Parametre olarak verilen ondalıklı sayıyı en yakın tam sayıya yuvarlamak için kullanılır.
            // Kullanımı: Math.Round(<deger1>);

            Console.WriteLine("Round()");
            Console.WriteLine("-------------------");
            Console.WriteLine("3.1 sayıyının yuvarlanmış hali: " + Math.Round(3.1));
            Console.WriteLine("3.9 sayıyının yuvarlanmış hali: " + Math.Round(3.9));

            Console.WriteLine();
            #endregion

            #region Sqrt()

            // Parametre olarak verilen sayının karekökünü hesaplayan metoddur.
            // Kullanımı: Math.Sqrt(<deger1>);

            Console.WriteLine("Sqrt()");
            Console.WriteLine("-------------------");
            Console.WriteLine("9 sayıyının karekökü: " + Math.Sqrt(9));
            Console.WriteLine("81 sayıyının karekökü: " + Math.Sqrt(81));

            Console.WriteLine();
            #endregion

            #region BigMul()

            // Parametre olarak verilen iki int değerin çarpımını long olarak geriye döndüren metoddur.
            // Kullanımı: Math.BigMul(<deger1>,<deger2>);

            Console.WriteLine("BigMul()");
            Console.WriteLine("-------------------");
            Console.WriteLine("1528999999 x 48759999: " + Math.BigMul(1528999999, 48759999));

            Console.WriteLine();
            #endregion

            #region Ceiling()

            // Parametre olarak verilen ondalıklı sayıyı yukarıya veya tamsayının aynısına yuvarlamak için kullanılır. Virgülden sonra 0 girilmiş ise kendi tam sayısına daha yüksek bir değer girildiyse yukarıya yuvarlama yapar.
            // Kullanımı: Math.Ceiling(<deger1>);

            Console.WriteLine("Ceiling()");
            Console.WriteLine("-------------------");
            Console.WriteLine("3.0 sayıyının yuvarlanmış hali: " + Math.Ceiling(3.0));
            Console.WriteLine("3.1 sayıyının yuvarlanmış hali: " + Math.Ceiling(3.1));

            Console.WriteLine();
            #endregion

            #region DivRem()

            // Bölme işleminde bölümü bulmak için kullanılan metoddur. Bölünen ve bölen girildiğinde geriye bölme işleminin sonucunu veren ve 3. parametre olarakta kalanı veren parametredir. Sayısal veri türlerinin tamamında kullanılabilir.
            // Kullanımı: Math.DivRem(<bolunen>,<bolen>,out <kalan>);

            Console.WriteLine("DivRem()");
            Console.WriteLine("-------------------");
            Console.WriteLine("18/4 işleminde:");
            int kalan;
            int bolum = Math.DivRem(18, 4, out kalan);
            Console.WriteLine("Bölüm: " + bolum);
            Console.WriteLine("Kalan: " + kalan);

            Console.WriteLine();
            #endregion

            #region Sign

            // Parametre olarak verilen sayının negatifmi, yoksa pozitif mi, yoksa sıfıra eşit mi olduğunu bulmak için kullanılan metoddur.
            // Geriye döndürüğü değerler;
            // 0 => parametre sıfıra eşit olduğunda
            // 1 => parametre pozitif değer olduğunda
            // -1 => parametre negatif sayı olduğunda döner.

            Console.WriteLine("Sign()");
            Console.WriteLine("-------------------");
            Console.Write("15 değeri: ");
            if (Math.Sign(15) == 0)
            {
                Console.Write("sıfıra eşit");
            }
            else if (Math.Sign(15) == 1)
            {
                Console.Write("pozitif");
            }
            else
            {
                Console.Write("negatif");
            }

            Console.WriteLine(" bir sayıdır.");

            #endregion

            Console.ReadKey();
        }
    }
}
