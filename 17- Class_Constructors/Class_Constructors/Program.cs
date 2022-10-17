using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructors
{
    class Program
    {

        public class kisiBilgileri
        {
            //Constructors: metot gibi kullanılır ancak ismi class ismi ile aynı olmak zorundadır.
            //Constructors doğrudan erişim yoktur. Sınıf içerisinden erişim sağlanır.

            public long tc;
            public string adsoyad, telefon;

            public kisiBilgileri(long _tc, string _adsoyad, string _telefon)
            {
                // tc = 15425789457;
                this.tc = _tc;
                this.adsoyad = _adsoyad;
                this.telefon = _telefon;


            }

            //parametreli çağırmak için metohod tanımlıyoruz
            public void yaz()
            {
                Console.WriteLine(tc);
                Console.WriteLine(adsoyad);
                Console.WriteLine(telefon);
            }
        }

        static void Main(string[] args)
        {

            /* kisiBilgileri kisi = new kisiBilgileri();  //kisiBilgileri sınıfından nesne türettik.

             Console.WriteLine(kisi.tc);*/



            //PARAMETRE KULLANRAK ;

            kisiBilgileri kisi = new kisiBilgileri(15424578988, "Ali Kaya", "1451547898");
            kisi.yaz();







            Console.ReadKey();




        }
    }
}
