using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual___Override
{
    internal class Calisan
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }

        public virtual double MaasHesapla() // çalışan da tanımladığım için virtual yazıyorum.
        {
            return 1300;
        }

        public override string ToString()
        {
            //return base.ToString();
            return this.Ad + " " + this.Soyad;
        }


    }
}
