using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenerik_Temsilci__Generic_Delegate_
{
    internal class Program
    {
        // Metotlar void olduğu için delegate'in de void olması gerekiyor.
        delegate void MyGenericDelegate<T>(T args);

        static void Main(string[] args)
        {
            // Temsilciler (Delegate)

            MyGenericDelegate<string> stringDelegate = new MyGenericDelegate<string>(StringTarget);
            stringDelegate("Kind World");

            MyGenericDelegate<int> intDelegate = new MyGenericDelegate<int>(IntTarget);
            intDelegate(1);

            Console.ReadLine();
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("Arg metnini büyüt : " + arg.ToUpper());
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine("++arg : " + ++arg);
        }
    }
}
