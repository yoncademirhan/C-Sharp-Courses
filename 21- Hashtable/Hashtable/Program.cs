using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Hashtable
{
     class Program
    {
        static void Main(string[] args)
        {
            // Hashtable Koleksiyonu
            // Array, ArrayList, List, vs... koleksiyonlarındaki elemanlara index numaraları ile erişim sağlanmaktadır.
            // Bazı durumlarda bu işleyiş uygun olmayabilir.
            // Çünkü nesnenin hangi indexe karşılık geldiğini bilmeniz gerekir.
            // Hashtable koleksiyonunda tanımlanan elemanlara isim verip o isim ile koleksiyon içerisindeki elemanlara erişim sağlayabilirsiniz. Buna anahtar-değer ilişkisi denir.

            // Hashtable koleksiyonunu kullanabilmek için System.Collections; kütüphanesinin eklenmesi gerekmektedir.

            // Syntax
            // -----------------
            // Hashtable <koleksiyonAdi> = new Hashtable();

            // Hashtable koleksiyone içerisinde eleman ekleme
            // <koleksiyonAdi>.Add(<anahtar>, <deger>);

            // Koleksiyon içerisine eleman ekleme işlemi yaparken anahtar ve deger tanımlaması object türdedir.

            Hashtable h = new Hashtable();
            h.Add("Anahtar1", 45);
            h.Add("Anahtar2", 67);

            Console.WriteLine("1. Anahtar: " + h["Anahtar1"]);
            Console.WriteLine("2. Anahtar: " + h["Anahtar2"]);

            Console.WriteLine();

            h["Anahtar1"] = "Merhaba";

            Console.WriteLine("1. Anahtar: " + h["Anahtar1"]);
            Console.WriteLine("2. Anahtar: " + h["Anahtar2"]);

            // Hashtable içerisinde kaç adet eleman barındığının bilgisine Count property si ile ulaşabilirsiniz.
            Console.WriteLine("Hashtable eleman sayısı: " + h.Count);


            // Hashtable içerisindeki elemanları direkt olarak döngü mekanizması ile ulaşamazsınız.
            // Öncelikle hastable içerisindeki Keys leri bir koleksiyon içerisine almanız gerekmektedir.
            // Bu keys bilgileri ICollection kolaksiyonu olarak geriye göner.

            ICollection anahtarlar = h.Keys;
            foreach (var key in anahtarlar)
            {
                Console.WriteLine(key);
            }

            ICollection degerler = h.Values;
            foreach (var deger in degerler)
            {
                Console.WriteLine(deger);
            }



            // Hashtable static olmayan GetEnumerator() ile hastable içerisinde barındırılan elemanlara ulaşım sağlayabilirsiniz. Bu metod geriye IDictionaryEnumerator türünden bir nesne döndürür. Bu nesne üzerinden MoveNext() ile koleksiyon ieçrisindeki elemanlar ile işlem yapabilirsiniz.
            // IDictionaryEnumerator nesnesi içerisinde Key ve Value propertyleri mevcuttur. Bu propertyler ile Hastable içerisinde tanımlanan elamanlara ulaşım sağlayabilirsiniz.

            // MoveNext() metodu koleksiyon içerisinde mevcut değerden başka bir değer varmı? diye sorgulamasını yazar. Eğer başka değer var ise true yok ise false değerini döndürür.


            Hashtable sozluk = new Hashtable();
            sozluk.Add("araba", "car");
            sozluk.Add("kitap", "book");
            sozluk["kalem"] = "pencil";

            var ide = sozluk.GetEnumerator();

            while (ide.MoveNext())
            {
                Console.WriteLine(ide.Key + " = " + ide.Value);
            }

            Console.WriteLine("Toplam kelime sayısı: " + sozluk.Count);

            Console.ReadKey();



        }
    }
}
