using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Araba
    {

       // public string Marka;
        public string Marka{ get; set; }

        public string Model { get; set; }
        public string Renk { get; set; }


        public void Yazdir()
        {
            Console.WriteLine("Marka: " + Marka);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Renk: " + Renk);
        }







        public Araba()
        {
            Console.WriteLine("Yeni bir Araba Class oluşturuldu");
        }


        public Araba(string _marka, string _model, string _renk)
        {
            Marka = _marka;
            Model = _model;
            Renk = _renk;
        }
    }
}
