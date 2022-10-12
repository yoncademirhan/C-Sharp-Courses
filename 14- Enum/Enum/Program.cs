using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{

    /*Enum(numaralndırmalar): 

           Numaralndırmalar(enumerations):
           kod içerisinde sayısal karşılaştırma veya işlem gerektiren yerlerde yazılımcı için daha okunabilirlik sunan kod karmaşasını azaltan yardımcı bir yapıdır.

           Syntax----
           <erisimtipi> <enumAdi> {<deger1> <deger2>, <deger3>, ...}

           *Enum yapısını kısa yoldan oluşturmak için yeni bir class oluşturup class degerini enum ile değştirebilirsiniz
           *
           *Enum içerisine deger vermezsek, degerlersıfır dan başlar.
           *Enumların varsayılan degeri int.dır.
           *

            */
    internal class Program
    {
        static void Main(string[] args)
        {
            int bugün =(int) Gun.Cumartesi;

           if(bugün == (int)Gun.Cumartesi || bugün == (int)Gun.Pazar)
            {
                Console.WriteLine("Hafta sonu");
            }
            else
            {
                Console.WriteLine("Hafta içi");
            }

            

           Console.ReadKey();

        }

    }
}
