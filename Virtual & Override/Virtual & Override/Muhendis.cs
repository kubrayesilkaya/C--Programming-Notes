using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual___Override
{
    internal class Muhendis : Calisan
    {
        public string Tur { get; set; }
        public string Departman { get; set; }

        public override double MaasHesapla()
        {
            //return base.MaasHesapla();
            //return 10000;
            return base.MaasHesapla() * 4 ;
        }
    }
}
