using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleri_Seviye_Sınıf_Kullanımı_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Advanced Class 3

            Islemler<double> sinif = new Islemler<double>();
            double sonuc = sinif.IslemYap(5.4D, 2);

            Console.WriteLine(sonuc);
            // not param değeri eksi olursa,bizim kurulumunu yaptığımız double'ın defaul değeri gelecek. Double'ın default değeri 0'dır.

            Console.ReadLine();
        }
    }

    class Islemler<T>
    {
        public T IslemYap(T kucukT, int param)
        {
            if(param >= 0)
            {
                return kucukT;
            }
            else
            {
                return default(T);
            }
        }
    }
}
