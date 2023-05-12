using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            string first = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            string second = Console.ReadLine();

            Console.WriteLine("Enter third string:");
            string third = Console.ReadLine();

            FindMaxGeneric<string> findMax = new FindMaxGeneric<string>(first, second, third);
            findMax.TestMaximum();

            Console.ReadLine();
        }
    }
}
