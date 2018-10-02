using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAppvs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter a number: ");
            string number = "";
            number = Console.ReadLine();
            Console.WriteLine($"The number you entered was: " + number);
            Console.ReadKey();
        }   
    }
}
