using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {

        //Inheritance (Kalıtım, Miras Alma): Bir nesnenin Farklı nesneler tarafından da kullanılmasına olanak sağlayan OOP özelliğidir.
        //Yazılan başka bir sınıfa miras edilebilir.
        //Bu miras alma işlemi tamamlandıgında miras alınan nesnenin tüm özellikleri o nesne içerisinde kullanılablir.
        //Bir nesneye sadece bir nesne miras edilebilir. Miras işlemleri zincirleme bir şekilde yapılabilir.
        static void Main(string[] args)
        {
            Insan i = new Insan();
            i.El = 2;
            i.Ayak = 2;

            Kopek k = new Kopek();
            k.Ayak = 4;

            i.Konus();
            k.Havla();


            Console.ReadKey();

        }
    }
}
