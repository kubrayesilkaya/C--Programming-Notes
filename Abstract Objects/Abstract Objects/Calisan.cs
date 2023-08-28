using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Objects
{
    abstract class Calisan
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }

        public string GetFullName()
        {
            return this.Ad + " " + this.Soyad;
        }

        public abstract double GetSalary();

        //public double GetSalary()
        //{
        //    return 1200;
        //}

        /* Abstract metot, metodun gövdesi ile birlikte yazılmaz. Çünkü biz bu metodun kesin olarak ezilmesi, override edilmesi gerektiğini söylüyoruz.
         * Böyle bir durumda metodun içeriğini vermenin hiçbir anlamı yoktur; zaten bunu alan kişiye içeriğini değiştirtmek istediğimiz için bunu zorunlu tutuyoruz.
         */

    }
}
