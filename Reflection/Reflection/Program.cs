using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reflection (Yansıma)

            /*
                Reflection Nedir?
            
                Reflection, bize hakkında bilgi sahibi olmadığınız programatik nesnelerle ilgili çalışma zamanında( run-time)
                bilgi alabilmemizi sağlayan bir yöntemdir.

                Örneğin, programın çalışma anında farklı bir DLL dosyasını uygulama içerisine dahil ederek içerisindeki metot ve
                dışarıya açık nesneleri kullabilmeyi sağlar.

             */

            Type t = typeof(MyClass);

            Console.WriteLine("İncelenecek Metot : " + t.Name);
            Console.WriteLine();

            Console.WriteLine("Desteklenen Metotlar : ");

            MethodInfo[] mi = t.GetMethods();

            foreach(MethodInfo m in mi)
            {
                Console.Write("   " + m.ReturnType.Name + " " + m.Name + "(");

                ParameterInfo[] pi = m.GetParameters();

                for(int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if(i + 1 < pi.Length)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine(")");
                Console.WriteLine();
                Console.ReadLine();
            }

            Console.ReadLine() ;
        }
    }

    class MyClass
    {
        int x;
        int y;

        public MyClass(int i, int j) 
        {
            x = i;
            y = j;
        }

        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            if(x < i && i < y)
                return true;
            else 
                return false;
        }

        public void Set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }

        public void Show()
        {
            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
    }
}
