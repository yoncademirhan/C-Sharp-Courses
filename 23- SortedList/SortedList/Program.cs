using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // SortedList koleksiyonun aynı hastableda olduğu gibi anahtar-değer çiftlerini barındırır.
            // hashtabledan farkı elemanlara index numarası ile erişilebiliyor olmasıdır.
            // Tabiki isminden de belli olduğu üzere içerisine eklanan her eleman sıralı bir şekilde eklenir.

            // Bu koleksiyonu kullanabilmeniz için System.Collections; kütüphanesini eklemaniz gerekmektedir.

            SortedList list = new SortedList();


            // Sortedlist içerisine değer ekleme
            list.Add("masa", "table");
            list["kitap"] = "book";
            list.Add("araba", "car");

            // SortedList içerisindeki tüm elemanları silmek için Clear();
            // list.Clear();

            // Contains() || ContainsKey() metodu koleksiyon içerisindeki belirtilen key bilgisi varmı? sorunusunu sorar. Geriye bool tipinde değer döndürür.

            Console.WriteLine(list.ContainsKey("araba") ? "var" : "yok");

            // ContainsValue() metodu koleksiyon içerisindeki belirtilen value bilgisi varmı? sorunusunu sorar. Geriye bool tipinde değer döndürür.
            Console.WriteLine(list.ContainsKey("car") ? "var" : "yok");

            // Sortedlist içerisindeki elemanları ekrana yazdırmak için GetEnumerator() metodunu kullanabilirsiniz.

            IDictionaryEnumerator ide = list.GetEnumerator();
            while (ide.MoveNext())
            {
                Console.WriteLine($"Anahtar: {ide.Key}- Değer: {ide.Value}" );
            }

            // sortedlist içerisindeki elemanı silmek için

            list.Remove("araba");
            list.RemoveAt(0);       //index numarasuna göre silme işlemi yapar.
            Console.WriteLine();

            IDictionaryEnumerator ide2= list.GetEnumerator();
            while (ide2.MoveNext())
            {
                Console.WriteLine($"Anahtar: {ide2.Key} - Değer: {ide2.Value}");
            }


            Console.ReadKey();


            // GetByIndex(index) => koleksiyon içersiindeki indeks nolu anahtar-değer çiftinin değer kısmını döndürür.
            // var deger = list.GetByIndex(0);

            // GetKey(index) => sortedlist nesnesindeki index umaralı elemanın key bilgisini döndürür.
            // var anahtar = list.GetKey(1);

            // GetKeyList() => list içerisindeki anahtarları IList türünden koleksiyona çevirir.
            //var anahtarlar = list.GetKeyList();
            //foreach (var _anahtar in anahtarlar)
            //{
            //    Console.WriteLine(_anahtar);
            //}

            //for (int i = 0; i < anahtarlar.Count; i++)
            //{
            //    Console.WriteLine(anahtarlar[i]);
            //}

            // GetValueList() => list içerisindeki değerleri IList türünden koleksiyona çevirir.
            var degerler = list.GetValueList();
            for (int i = 0; i < degerler.Count; i++)
            {
                Console.WriteLine(degerler[i]);
            }




        }
    }
}
