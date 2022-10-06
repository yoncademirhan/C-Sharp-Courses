using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220817_1_Property
{
    public class Kisi
    {
        // Property
        // Bir class içerisinde bulunan bazı alanlara başka bir class içerisinden her zaman ulaşmak gerekmez.
        // Oluşturulan bu private alanlara kontrollü birşekilde erişim sağlamak için Property tanımlanmaktadır.
        // Property tanımı ile bu alanları get(okumak) edebilir, set(atamak) edebilir, yada her ikisinede aynı anda belirleyebilirsiniz.

        // Syntax
        // private int myVar;

        // public int MyProperty
        // {
        //    get { return myVar; } // okunabilir.
        //    set { myVar = value; } // yazılabilir.
        // }

        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        private int _yas;

        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("18 yaşından küçük kişiler üye olamaz.");
                }
                else
                {
                    _yas = value;
                }
            }
        }


    }
}
