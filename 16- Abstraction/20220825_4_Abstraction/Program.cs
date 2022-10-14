using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220825_4_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d = new Dikdortgen();
            d.Boy = 5;
            d.En = 3;
            Console.WriteLine("Dikdörtgenin Çevresi: " + d.Cevre());

            Console.ReadKey();
        }
    }
}
