using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Genişletme_Metotları__Extension_Methods_
{
    public static class MyExtensions
    {
        public static void DisplayASMInfo(this object obj) 
        {
            Console.WriteLine("Object Type : {0}, Assembly : \n", obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        /// <summary>
        /// Projedeki her int veri tipi için kullanılabilir olan "karesini alma" metodudur.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>

        public static int Square(this int i)
        {
            return i * i;
        }

        public static void ShowItems(this System.Collections.IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
            }

            // Artık bir liste oluşturduğumuzda, herhangi bir generic liste (Collections), ShowItems metoduna sahip olacak,
            // ve bunu çağırdığımız zaman otomatik olarak o item içerisindeki tüm veriyi listeleyecek ekranda. 
        }
    }
}
