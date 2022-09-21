using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* List<int> sayilar = new List<int>();*/

            //List <T> koleksiyonu içerisinde değer ekleme  işlmei. Add(<deger>); metodu ile yapabilirsiniz.

            sayilar.Add(15);
             sayilar.Add(48);
             sayilar.Add(37);

            //List <T> koleksiyonu içerisindeki eleman sayısını öğrenmek için  .Count proprty'sini kullanabilirsiniz.
            //Bu property geriye int değer döndürr.

            Console.WriteLine("Koleksiyon içerisindeki eleman sayısı: " + sayilar.Count);

            //koleksiyon içewrisindeki degerleri okuyalım(for);
             for(int i = 0; i < sayilar.Count; i++)
             {
                 Console.Write(sayilar[i] + " ");
             }
             Console.WriteLine();

             //koleksiyon içewrisindeki degerleri okuyalım(foreach)

             foreach(var sayi in sayilar)
             {
                 Console.Write(sayi + " ");
             }

             Console.WriteLine();


            //List<T> koleksiyonu içerisindeki değerleri çıkartmak için 2 farklı metot kullanılır.Remove() ve RemoveAt() metotlarıdır.
            //Remove (<deger>); remove metotu içeriine değer belirtilir. Belirtilen değeri koleksiyon içerinden cıakrtır.
            //RemoveAt(<indexNumarasi>); RemoveAt metotu içeriine index numarası belirtilir. Belirtilen ndex numarasındaki eleman listeden cıkartır.

             sayilar.Remove(48);
             sayilar.RemoveAt(0);  //,index numarasına göre seçim yapılır.


             foreach (var sayi in sayilar)
             {
                 Console.Write(sayi + " ");
             }

             Console.WriteLine();

            //List<T> koleksiyonu içerisindeki tüm elemanları silmek için Clear() metotu kullanılır.
            // sayilar.Clear();  // Koleksiyon içeriisndeki tüm elemanları siler.




            //Örnek: Kullanıcıdan 10 adet şehir ismi talep edelim. Talep ettiğimiz şehir isimlerini koleksiyon içerisinde baarındıralım.
            //Koleksiyon içeriindeki verileri ekrana yazdıralım.

            //Çözüm:
            ist<string>sehirler = new List<string>();

             for (int i = 0; i < 10; i++)
             {
                 Console.Write($"{i + 1}.şehir bilgisini giriniz.");
                 sehirler.Add(Console.ReadLine());
             }

             Console.WriteLine();
             Console.WriteLine("Şehirler");
             Console.WriteLine("--------------");
             foreach (var sehir in sehirler)
             { 
                 Console.WriteLine(sehir);
             }



            //Örnek: Sayı tutma ve toplama programı
            /* 1- sayı gir
             * 2- sayıları listele
             * 3- sayı sil
             * 4-Sayıların Toplamı
             * 5- Sayıların ortalamsı
             * X programdan cık  */



            ConsoleKey islem;
            List<double> sayilar = new List<double>();

            do
            {
                Console.Clear();

                Console.WriteLine("Sayı tutma ve toplama programı");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1- sayı gir");
                Console.WriteLine("2- sayıları listele");
                Console.WriteLine("3- sayı sil");
                Console.WriteLine("4-Sayıların Toplamı");
                Console.WriteLine("X programdan cık ");
                Console.WriteLine();
                Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
                islem = Console.ReadKey().Key;

                Console.Clear();

                switch (islem)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //Sayı gir
                        Console.WriteLine("Eklemek istediğiniz sayıyı giriniz: ");
                        sayilar.Add(double.Parse(Console.ReadLine()));

                        Console.WriteLine();
                        Console.WriteLine("Sayı başarılı bir şekilde eklendi.");
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //komut satırı
                        Console.WriteLine("girilen sayılar");
                        Console.WriteLine("-------------");
                        foreach (var sayi in sayilar)
                        {
                            Console.Write(sayi + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine($"{sayilar.Count} adet sayı listelendi");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //komut satırı
                        Console.WriteLine("girilen sayılar");
                        Console.WriteLine("-------------");
                        for(int i=0; i < sayilar.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. sayı: {sayilar[i]}");
                        }
                        Console.WriteLine();
                        Console.Write("Silmek istediğiniz sayının sıra numarasını giriniz: ");
                        int siraNo = int.Parse(Console.ReadLine());

                        sayilar.RemoveAt(siraNo - 1);

                        Console.WriteLine("Seçmiş oldugunuz sayı silmiştir.");
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        //komut satırı
                        double toplam = 0;
                        foreach( var sayi in sayilar)
                        {
                            toplam += sayi;
                        }
                        Console.WriteLine("girilen sayıların toplamı: " + toplam);
                        Console.WriteLine();
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        //komut satırı
                        double toplam2 = 0;
                        foreach ( var sayi in sayilar)
                        {
                            toplam2 += sayi;
                        }
                        Console.WriteLine("girilen sayıların ortalaması: " + (toplam2 / sayilar.Count));
                        Console.WriteLine();
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadKey();
                        break;
                }


            } while (islem != ConsoleKey.X);

            Console.WriteLine();
            Console.WriteLine("Programı kullandığınız için teşekkür ederiz");
            Console.WriteLine("Uygulamayı kapğatmak için bir tuşa basınız");









            Console.ReadKey();
        }
    }
}
