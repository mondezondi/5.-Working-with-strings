using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" This will write same line ");
            Console.WriteLine(" This will \n wrap to next line ");
            Console.WriteLine(" This will \" print out the quotation mark. ");

            String FirstName = "Nomonde";
            String lastName = "Zondi";

            Console.WriteLine(FirstName + " " + lastName);

            Console.WriteLine(lastName.Length);

            Console.WriteLine(FirstName.ToUpper());

            Console.WriteLine(lastName.Contains("Fu"));

            Console.WriteLine(FirstName[0]);

            Console.WriteLine(" Index of a is ");
            Console.WriteLine(lastName.IndexOf('a'));

            Console.WriteLine(FirstName.Substring(1));

            Console.WriteLine(FirstName.Substring(1, 2));
            Console.ReadLine();

        }
    }
}
