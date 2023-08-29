using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleri_Seviye_Sınıf_Kullanımı_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Advanced Class

            //Liste liste = new Liste();
            //Liste<decimal> liste = new Liste<decimal>();

            Liste<string> liste = new Liste<string>();
            liste.Add("Yoona");
            liste.Add("Sun");
            liste.Get();
            

            Console.ReadLine();
        }
    }

    class Liste
    {

    }

    //class Liste<T> //class overloading. T = TYPE ANLAMINA GELİR.
    //{
    //    public Liste() 
    //    {
    //        Console.WriteLine(typeof(T));
    //    }
    //}

    class Liste<T>
    {
        List<T> list = new List<T>();

        public void Add(T kucukT)
        {
            list.Add(kucukT); //dışardıan gelen küçükt yi, içerideki list'e ekliyorum.
        }
        
        public void Get()
        {
            foreach (var t in list)
            {
                Console.WriteLine("t -> " + t);
            }
        }
    }


}
