using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //file sınıfı programınız içerisine dosya oluşturma, kopyalma, taşıma, silme ve benzeri işlemleri yapmamızı sağlar.
            //Kullanımı için System.IO kütüphanesinin eklenmesi gerekmektedir.

            //Dosya oluşruma:

            File.Create(@"D:/test.txt");            // D içine test isimli dosya oluşlturulur.



            //file.copy(<kaynak>, <hedef>(;
            //Belirtilen kaynkatki dosyayı belirtilen hedefe kopyalar.

            File.Copy("d:/test.txt", "d:/Deneme/kopya.txt");        //tst.txt dosyasını denmee klasörü içine kopya.txt ismi ile kopyalar.


            //File.Move: Belirtilen kaynaktaki dosyayı belirtilen hedefe taşır.

            File.Move("d:/test.txt", "d:/Deneme/tasinan.txt");


            //File.Delete: Belirtilen hedefteki dosyayı siler.

            File.Delete("d:/deneme/kopya.txt");             //deneme klasörü içindeki kopya.txt dosyasını siler.


            //File.Exists: Belirtilen hedefte istenilen dosya var mı sorgusunu yapar. geriye boolean deger döndürür.

            if (File.Exists("d:/deneme/tasinan.txt"))           //deneme klasörü içinde tasinan.txt dosyası var mı ?
            {
                Console.WriteLine("Dosya var");
            }
            else
            {
                Console.WriteLine("dosya yok");
            }

            //Belirertilen dosya içerisine yazı yazdırma:

            string dosyaYolu = "d:/deneme/yeni.txt";
            File.Create(dosyaYolu);             //d içine yeni bir dosya oluşturuldu.


            string[] yazilar = { "Birinci Satır", "İkinci satır", "Üçüncü Satır..." };
            File.WriteAllLines(dosyaYolu, yazilar);                 //oluşturulan dosya içine yazilar yazıldı.


            //Dosya içerisindeki metinleri okumak

            string[] satirlar = File.ReadAllLines(dosyaYolu);       //dosya içindeki metinleri okur. console.Write ile Ekrana Yazdırı.
            foreach (var satir in satirlar)
            {
                Console.WriteLine(satir);
            }





            Console.ReadKey();
        }
    }
}
