using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    internal class IkiBoyut
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public void Goster()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Genişlik : " + Genislik);
            builder.Append(Environment.NewLine);
            builder.Append("Yükseklik : " + Yukseklik);
            builder.Append(Environment.NewLine);
            Console.WriteLine(builder.ToString());
        }
    }
}
