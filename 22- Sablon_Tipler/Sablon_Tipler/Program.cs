using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sablon_Tipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan kaç adet kelime gireceğini sorun
            //Kullanıcıdan kelimeleri ve ingilizce karşılıklarını taalep edin
            //Girilen değerleri Hastable içerisinde tutun ve ekrana yazın.



            Console.WriteLine("Kaç adet Kelime Gireceksiniz: ");
            int adet = int.Parse(Console.ReadLine());

            Hashtable kelimeler = new Hashtable();

            for (int i = 0; i < adet; i++)
            {

                Console.WriteLine($"{i + 1}. Kelimeleyi Türkçe  Olarak Yazınız: ");
                string kelime1 = Console.ReadLine();
                Console.WriteLine($"{i + 1}.  Kelimeleyi İngilizce Olarak Yazınız: ");
                string kelime1Eng = Console.ReadLine();    

                kelimeler.Add(kelime1,kelime1Eng);
            }
            var saymak = kelimeler.GetEnumerator();

            while (saymak.MoveNext())
            {
                Console.WriteLine(saymak.Key + " = " + saymak.Value);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(kelimeler.Count + " Adet var.");

            Console.ReadKey();
        }




    }
}
