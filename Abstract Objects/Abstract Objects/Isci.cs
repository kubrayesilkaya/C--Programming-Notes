using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Objects
{
    internal class Isci : Calisan
    {
        public Isci() 
        {
            Unvan = "İşçi";
        }

        public override double GetSalary()
        {
            return 1300;
        }
    }
}
