using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metotlar:

            /*Yazdığınız program içerisinde bazı durumlarda aynı türden birden fazla veri tutmak isteyebilirsiniz.

             * Bu gibi durumlarda Array mantığı devreye girer.
             *Diziler birden fazla değer alabilen değişkenler olarak düşünebilirsiniz.Diğer bir tanımı aynı türdeki verileri tek bir isim altında saklamanızı ve bu verileri okuyup işleme almanızı sağlar.
             *
             *Syntax
             * ----------------
             * < VeriTipi >[] < diziAdi > = new < VeriTipi >[ElemanSayisi]
             *
             *
             *Dizi tanımlama işlemi yukarıda belirtilmiştir. Dizi tanımlama işlemi esnasında içerisinde kaç adet eleman barındırılacak ise eleman sayısını belirtmek zorundasınız. Belirtilen eleman sayısı büyüklüğünde bir dizi oluşturulur.İçerisindeki değerler ilk tanımlama işlemi esnasında null(boş)'tur.
             *
             *Dizi oluşturma işlemi sonrasında bu dizi içerisine index numarası aracılığı ile değer atayabilir veya dizi içerisindeki değerleri okuyabilirsiniz.
             *
             *Dizi içerisine değer atama işlemi
             *-----------------------------------
             * < diziAdi >[indexNumarasi] = < değer >;
            *
            *Dizi içerisindeki değeri okuma işlemi
             *---------------------------------------
             * < diziAdi >[indexNumarası]
             *

            /* <diziAdi>.Lenght ? dizi içindeki eleman sayısını veriri.
             * Array.Clear(<diziAdi>, <baslangicNumarasi>, <temizlenecekElemanSayisi>);
            
             * Array.Reverse(<diziAdi>);     Dizi içindekği  möetinsel değerleri z den a ya, sayısal değerleri büyükten küçüğe dogru sıralar.
             
             * Array.Sort(<diziAdi>);  metinsel değerleri a dan z ye, sayısal değerleri küçükten büyüğe dogru sırlar.
            
             * array.Indexof(<diziAdi>);  Dizi içerisinde eleman aramak için kullanılır.elemanı bulursa index degeri döndürür. Bulamazsa -1 döndürür. Büyük - küçük harfe duyarlıdır.
             
             * */

            //Örnek: 

             string[] diller = new string[6];
             diller[0] = "#C";
             diller[1] = "Html";
             diller[2] = "Css";
             diller[3] = "Sql";
             diller[4] = "#C";
             diller[5] = "ReactNative";

             Console.WriteLine("Dizinin Eleman Sayısı: " + diller.Length);  //dizinin uzunlugunu verir.

             Array.Clear(diller, 1, 2); //1.indexten başlayp iki tane siler.

             Console.WriteLine();

             Console.WriteLine("Silme işlemi sonrası listeleme: ");
             Console.WriteLine();

             for (int i = 0; i < diller.Length; i++)
             {
                 Console.WriteLine(diller[i]);
             }


             diller[1] = "Html";
             diller[2] = "Css";

             Array.Sort(diller);

             Console.WriteLine();
             Console.WriteLine("Sort() işlemi sonrası listeleme:");
             Console.WriteLine("----------------------------");

             for (int i = 0; i < diller.Length; i++)
             {
                 Console.WriteLine(diller[i]);
             }


             Array.Reverse(diller);

             Console.WriteLine();
             Console.WriteLine("Reverse() işlemi sonrası listeleme:");
             Console.WriteLine("----------------------------");

             for (int i = 0; i < diller.Length; i++)
             {
                 Console.WriteLine(diller[i]);
             }


             Console.WriteLine();
             Console.WriteLine("IndexOf() işlemi sonrası");
             Console.WriteLine("---------------");
             int sonuc = Array.IndexOf(diller, "C#");
             if(sonuc == -1)
             {
                 Console.WriteLine("Aranılan değer bulunamadı");
             }
             else
             {
                 Console.WriteLine($"Aranılan değer {sonuc + 1}. sıradadır.");
             }
            

            //Örnek: Kullanıcıdan 10 adet sayı talep edelim. Kullanıcının girmiş ldugu sayılardan en büyük ve en küçük sayı arasındaki farkı yazdıralım.

            //Çözüm:

            char cevap = ' ';
            do
            {
                Console.Clear();
                Console.Write("Kaç adet sayı girmek istersiniz: ");
                int adet = int.Parse(Console.ReadLine());

                int[] sayilar = new int[adet];

                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.Write($"{i + 1}. sayıyı giriniz:");
                    sayilar[i] = int.Parse(Console.ReadLine());

                }

                Array.Sort(sayilar);
                int enKucuk = sayilar[0], enBuyuk = sayilar[sayilar.Length - 1];


                Console.WriteLine();
                Console.WriteLine("En küçük sayı: " + enKucuk); ;
                Console.WriteLine("En büyük sayı: " + enBuyuk);
                Console.WriteLine("Farkları: " + (enBuyuk - enKucuk));

                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Yeniden işlem yapmak ister misiniz?(e) ");
                cevap= char.Parse(Console.ReadLine());
                // cevap= console.RadKey().KeyChar; //Klavyede hangi tuşa basıldı ise o tuşun char karşılıgını verir.




            } while (cevap == 'e' || cevap == 'E');

            Console.WriteLine();
            Console.WriteLine("Programı kullandıgınız için teşekkür ederiz.");
            Console.WriteLine("Programı kapatmak çin herhangi bir tuşa basınız.");














            Console.ReadKey();
        }
    }
}
