using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleri_Seviye_Sınıf_Kullanımı_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Advanced Class 

            MyList<string> liste = new MyList<string>();
            liste.Ekle("İstanbul");
            liste.Ekle("Ankara");

            Console.WriteLine("Eleman Sayısı : " + liste.ElementSayi);

            Console.ReadLine();
        }
    }

    class MyList<T>
    {
        T[] dizi;
        public void Ekle (T deger)
        {
            try
            {
                T[] geciciDizi = new T[dizi.Length];
                geciciDizi = dizi;
                dizi = new T[geciciDizi.Length + 1];
                for(int i = 0; i < geciciDizi.Length; i++)
                {
                    dizi[i] = geciciDizi[i];
                }
                dizi[dizi.Length - 1] = deger;
            }
            catch 
            {
                dizi = new T[1];
                dizi[0] = deger;
            }
        }

        public int ElementSayi
        {
            get { return dizi.Length; }
        }
    }
}
