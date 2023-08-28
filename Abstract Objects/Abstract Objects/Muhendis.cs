using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Objects
{
    internal class Muhendis : Calisan 
    {
        public Muhendis() 
        {
            Unvan = "Mühendis";
        }

        public override double GetSalary()
        {
            return 4000;
        }
    }
}
