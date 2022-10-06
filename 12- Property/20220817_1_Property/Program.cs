using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220817_1_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k = new Kisi();
            k.Ad = "Ali";
            k.Soyad = "TOPÇU";
            k.Yas = 15;
            Console.WriteLine(k.Ad);
            Console.WriteLine(k.Soyad);
            Console.WriteLine(k.Yas);

            Console.ReadKey();
        }
    }
}
