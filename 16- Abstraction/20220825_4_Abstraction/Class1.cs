using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220825_4_Abstraction
{
    // Abtraction(Soyutlama)
    // Karmaşıklığı yönetmek için kullanılır. Nesnenin diğer tüm nesne türlerinden ayıran temel özelliklerini belirtir, böylece izleyicinin bakış açısından açıkça tanımlanmış bir kavramsal sınır sağlar.
    // Nesne yönelimli programlamalarda, ayırma, ayrıntıları tanımlamaktan ziyade sınıflar ve yöntemler için temel görevleri tanımlamak için kullanılır. 
    // Temel olarak,problemi çözmek için kullanılan öncelikle daha genel, daha basit ve soyuttur.

    // Abstract classlar soyut sınıflardır.

    public abstract class Sekil
    {
        public int Cevre()
        {
            return 0;
        }
    }



    public class Dikdortgen : Sekil
    {
        public int En { get; set; }
        public int Boy { get; set; }

        public int Cevre()
        {
            return (2 * (En + Boy));
        }
    }
}
