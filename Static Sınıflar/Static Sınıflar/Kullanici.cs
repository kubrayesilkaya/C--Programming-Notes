using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Sınıflar
{
    internal class Kullanici
    {
        public static int ID { get; set; }
        public string Ad { get; set; }
        public int PrivateID { get; set; }

        public Kullanici ()
        {
            ID += 1;
            PrivateID += ID;
        }

        public int GetId()
        {
            return Kullanici.ID;
        }
    }
}
