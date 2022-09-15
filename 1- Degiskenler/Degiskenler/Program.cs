using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Değişkenler
            * ----------------------
            * Programlama içerisinde bazı durumlarda kullanıcıdan veya programlama işlemi esnasında elde etmiş olduğumuz değerleri hatırlamak isteyebiliriz. Bu gibi durumlarda değişkenler devreye girer. Programlama dili içerisinde tanımlamış olduğumuz bir değişkeni uygulama kapanana kadar erişim sağlayabiliriz.
            *
            * Değişkenleri tanımlamak için bir yazım kuralı bulunmaktadır.
            *
            * <VeriTipi> <değişkenAdı> = <değer>;
            *
            */

            string metin = "Merhaba";
            char karakter = 'a';
            int s1 = 5;
            long s2 = 123;
            double s3 = 32.5;
            float s4 = 45.3f;
            decimal s5 = 99.90m;
            short s6 = 132;
            bool deger = true; // false

            object obj1 = "selam";
            object obj2 = 5;
            object obj3 = false;

            var v1 = "metin";
            var v2 = 56;
            var v3 = 34.9m;
            var v4 = true;


            // Değişken tanımlama kuralları

            // 1- Kelimeler arasında boşluk bırakılamaz. Boşluk yerine _ (alt tire) kullanabilirsiniz.
            // 2- Sayı ile başlayamaz.
            // 3- Özel karakter kullanılamaz. Sadece _ kullanılabilir.
            // 4- Programlama dili için tanımlanmış anahtar kelimleri içermemesi gerekmektedir.


        }
    }
}
