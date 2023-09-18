using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma___Kelimelerin_Anagram_Kontrolünü_Yapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritma : Kelimelerin Anagram Kontrolünü Yapma

            /*
                Algoritmanın Amacı

                İki kelimenin birbirine anagram olup olmadığını bulmayı sağlar.

                Anagram nedir?

                İki kelimenin farklı olması ama aynı harflerden oluştuğu durumlara angram denir.

                Örneğin; Silent -> Listen anagramlık içerir.
             */

            Console.WriteLine("İlk Kelime : ");
            string word1 = Console.ReadLine();
            Console.WriteLine("İkinci Kelime : ");
            string word2 = Console.ReadLine();

            char[] ch1 = word1.ToLower().ToCharArray();
            char[] ch2 = word2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string str1 = new string(ch1);
            string str2 = new string(ch2);

            if(str1 == str2)
            {
                Console.WriteLine("\"{0}\" ve \"{1}\" Anagram'dır.", word1, word2);
            }
            else
            {
                Console.WriteLine("\"{0}\" ve \"{1}\" Anagram değildir.", word1, word2);
            }

            Console.ReadLine();
        }
    }
}
