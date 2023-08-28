using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Partial Class

            People people = new People();
            people.FirstName = "Yoona";
            people.LastName = "Sun";
            people.Email = "yoona.sun@hotmail.com";
            people.Password = "smile";
            people.BirthDate = new DateTime(2000, 08, 28);

            Console.WriteLine(people.GetFullName());
            Console.WriteLine(people.GetEmail(2));

            Console.ReadLine();
        }
    }
}
