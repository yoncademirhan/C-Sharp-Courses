using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Drectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Directory , uygulama içerisinde klasör oluşturmamızı sağlayan bir sınıf yapısıdır.
             * Bu sınıf yapısını kullanabilmemiz için öncelikle namespace kısmına using.IO kütüphaneisni eklmemeiz gerekmektedir.
             * 
             * 
             * 
             * Directory.Getfiles()
             * 
             * Getfiles() directory sınıfında static olarak tnaımlandıgında instance almaya ihtiyaç duymadan direkt olarak kullnamamıza olanak sağlar.
             * Belirtilen Klasör yolu içeriisndeki dosya isimlerini string[] halide geriye döndürür.
             */


            string[] dosyaListesi = Directory.GetFiles(" C://");        //C içindeki dosyalara erişim sağlanır.

            foreach (var dosya in dosyaListesi)
            {
                Console.WriteLine(dosya);
            }

            Console.WriteLine();


            /*
             * Directory.Exist()
             * Exists Methodu ile belirtilen klasör yolunu var olup olmadıgını sorgulamak için kullnaılır.Ferieye boolean deger dmndürür.
             * 
             * */


            string klasoryolu = @"c:/Drivers";              // c içinde Drivers isimli klasör olup olmadıgını konrtol eder.
            if (Directory.Exists(klasoryolu))
            {
                Console.WriteLine("klasör var");
            }
            else
            {
                Console.WriteLine("klasör yok");
            }



            /*
             * directory.CreateDirectory()
             * Method içeriisne belirtilen klasör yolunda klasör oluşturmamızı sağlar.Geriye DirectoryInfo tipinde veri döndürü. Bu class yapısı ile oluşturlan klasörün bilgilerne erişim sağlayabiliriz.
             * 
             * */

            Directory.CreateDirectory(@"C:/Deneme Klasörü");        //c nin içine Deneme klasörü isimli yeni bir klasör oluşturuldu.


            Directory.Delete(@"C:/Deneme Klasörü");                 // c içindeki Deneme klasörünü siler.

            Console.ReadKey();
     
        }
    }
}
