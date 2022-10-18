using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Abstract
{
        class Program
    {

        //Abstract Class: bir sınıfın özelliklerini diğer mirasçı classlarda kullandıgımız ancak kendisinden nesne türetilemeyen soyut sınıflardır. Yani new anahtar sözcüğü kullanılmaz.
        //ancak referans olarak kullanılabşlşrler. diğer classlara temek class olma görevini üstlenirler.

        //Abstract Method: Abstract Classların içinde tanımlanan içi boş olan daha sonra mirasçı sııfta tanımlanırken override edilerek kullanılabilen methodlardır.

        abstract class tasit
        {
            public string marka, seri, renk;
            public int yil, km;
            abstract public void t_ozellik();
            public void method()
            {
                Console.WriteLine("Taşıt sınıfı Çağırıldı");
            }
        }

        class otomobil: tasit
        {
            public override void t_ozellik()
            {
                Console.WriteLine(marka);
                Console.WriteLine(seri);
                Console.WriteLine(renk);
                Console.WriteLine(yil);
                Console.WriteLine(km);
            }
        }





        static void Main(string[] args)
        {
            otomobil oto = new otomobil();
            oto.marka = "Ford";
            oto.seri = "Focus";
            oto.renk = "Beyaz";
            oto.yil = 2018;
            oto.km = 50000;

            oto.t_ozellik();
            oto.method();



            Console.ReadKey();
        }
    }
}
