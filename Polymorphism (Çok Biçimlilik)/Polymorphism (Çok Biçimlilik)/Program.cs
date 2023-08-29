using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism__Çok_Biçimlilik_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism (Çok Bitimlilik)

            Basket basket = new Basket();

            Bread ekmek = new Bread(BreadType.Odun);
            ekmek.ProductCode = "BRD-7566986696";
            ekmek.ProductName = BreadType.Odun.ToString();

            Tekstil tekstil = new Tekstil();
            tekstil.Marka = TekstilMarka.Beymen;
            tekstil.ProductCode = "TKS-8226562626";
            tekstil.ProductName = "Özel Dikim";
            tekstil.Price = 250.5;

            basket.Add(ekmek);
            basket.Add(tekstil);

            Console.WriteLine("Toplam Fiyat (KDV Hariç) : " + basket.TotalPrice());
            Console.WriteLine("Toplam Fiyat (KDV Dahi) : " + basket.TotalPriceWithKDV());
            Console.WriteLine("Sipariş KDV Toplamı : " + (basket.TotalPriceWithKDV() - basket.TotalPrice()));

            Console.WriteLine("******************************************************************************");

            foreach(var prd in basket.GetProducts()) 
            {
                Console.WriteLine(prd.ProductCode + " / " + prd.ProductName + " - " + prd.Price);
            }


            Console.ReadLine();
        }
    }
}
