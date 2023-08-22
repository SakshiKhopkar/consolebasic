using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Teenager_or_not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age of the person");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age <= 14)
            {
                Console.WriteLine("The person is teenager");
            }
            else
            {
                Console.WriteLine("The person is not teenager");
            }
        }
    }
}
