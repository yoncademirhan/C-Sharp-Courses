using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar_Fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metodlar (Fonksiyonlar)

            // 
            // Programlama dilleri içerisinde yazılan uyglama içerisinde kendini tekrarlayan işlem satırlarını paketleyip istediğiniz zaman kullanabildiğiniz bir yapıdır.
            // Örnek vermek gerekirsen birden fazla sayının toplamını almak istiyorsunuz ve bu işlem için her seferinde aynı komut satırlarını yazmak zorunda kalabilirsiniz.
            // Bu durumu ekarte etmek için fonksiyon mekanizmasını kullanırız.


            // Metodların Avantajları:
            // ------------------------
            // - aynı kodu defalarca yazmaya gerek kalmaz.
            // - Zamandan tasarruf sağlar.
            // - Program içerisindeki komut satırları azalır.
            // - Programın okunabilirliği ve anlaşılabilirliği artar.
            // - Program yapısal bir görünüm kazanır.

            // Dezavantajları:
            // -----------------------
            // Metodlar tek başlarına çalışmazlar, metodların çalışabilmesi için program içerisinden çağırılması gerekmektedir.

            // Metod tanımlama Syntax
            // ---------------------------------
            // <erisimTuru> <donusTipi> <metodAdi> (<parametre|ler>) {
            //      // matod içinde çalışacak komut satırları
            //      // matod içinde çalışacak komut satırları
            //      // matod içinde çalışacak komut satırları
            // }


            // Metod tanımlamak için bilinmesi gerekenler:

            // Erişim Türleri:
            // ----------------------
            // Erişim türünde programın diğer bölümlerinden erişilip, erişilemeyeceğini belirlemek için kullanılır.

            // Başlıca erişim türleri
            // - Public: Halka açık manasına gelir. Uygulama içerisinden ve referans olarak eklenmiş olan tüm projelerden erişim sağlanabilir.
            // - Static: Sabit olarak tanımlamabilen metodlardır. Bu metodlar uygulama ilk çalıştığı anda RAM üzerinde yapılandırılır ve çağırma işlemi yapılmadan direk olarak kullanabilirsiniz.
            // - Private: Özel(Gizli) olarak sınıflandırlan metodlardır. Bu metodlara sadece kendi sınıfı içerisinden erişim sağlanabilmektedir. Başka hiçbir yerden erişim sağlanamaz.
            // - Internal: Sadece kendi projesi üzerinden erişim sağlanmaktadır.


            // Dönüş tipi:
            // -------------------------
            // Dönüş tipini geriye değer döndürmesini istiyorsak int,string,char[],List<double>, vs... tanımlayabiliriz.
            // Metod içerisindede geriye dönecek olan değeri return ifadesi ile döndürürüz.
            // Geriye bir değer dönemeyecek ise <donusTipi> yerine void ifadesi yazılır.
            // Bu sayede uygulama metodun geriye değer döndürmeyeceğini anlar ve içerisindeki komut satırlarını tamamlayıp işlemi sonlandırır.


            // Metod ismi:
            // ----------------------------
            // Metod ismi tanımlarken değişken tanımlama kurallarına birebir uyulması gerekmektedir.


            // Parametreler:
            // -------------------
            // Metodlar kendiiçerisinde parametre almak zorunda değildirler. 
            // Parametre alacaklar ise alacakları parametlerin türü ve metod içerisinde kullanılacak olan isimilerin belirtilmesi gerekmektedir.
            // Birden fazla parametre belirtilecek ise aralarında virgül kullanırlır.

            // Örnek: (int sayi, string metin, vb...) şeklinde tanımlamalar yapılabilir.



            // Genel Bilglendirme:
            // -------------------------
            // Fonksiyonlar Class yapılarının içerisinde bulunan mekanizmalardandır.
            // Bir fonksiyon yazılacağı zaman Class içerisine yazılmalıdır.
            // Static olarak tanımlanmış Class yapıları içerisine sadece static erişim türünde metodlar yazabilirsiniz.

            #endregion

            Yazdir();
            //Yazdir();
            //Yazdir();

            KarsilamaMesaji("Ahmet");
            //KarsilamaMesaji("Mehmet");
            //KarsilamaMesaji("Fatma");

            Console.WriteLine();
            Console.Write("İsminizi giriniz: ");
            string ad = Console.ReadLine();
            KarsilamaMesaji(ad);

            // Yarı çapı 5cm olan çemberin çapını hesaplayalım.
            Console.Write("Yarı çapı 5cm olan çemberin çevresi: ");
            double cemberCap = (5 * 5) * PiSayisi();
            Console.WriteLine(cemberCap);

            Console.WriteLine();
            Console.WriteLine(TamAd("Ali", "KAÇAR"));


            Console.ReadKey();
        }


        // Syntax
        // <erisimTuru> <donusTipi> <metodAdi> (<parametre|ler>) {
        //      // matod içinde çalışacak komut satırları
        //      // matod içinde çalışacak komut satırları
        //      // matod içinde çalışacak komut satırları
        // }


        // Geriye dönüşü olmayan parametre almayan metod
        static void Yazdir() // erişim türü yazılmadığında default olarak private kabul edilir.
        {
            Console.WriteLine("Merhaba Dünya");
        }

        // Geriye dönüşü olmayan parametre alan metod
        static void KarsilamaMesaji(string isim)
        {
            Console.WriteLine("Hoşgeldin " + isim);
        }

        // Geriye dönüşü olan parametre almayan metod
        static double PiSayisi()
        {
            // Math.PI;
            double pi = 3.14;
            return pi;
        }

        // Geriye dönüşü olan parametre alan metod
        static string TamAd(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }
    }
    }
}
