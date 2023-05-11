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
            Console.WriteLine("Enter first value:");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second value:");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third value:");
            int third = Convert.ToInt32(Console.ReadLine());

            FindMaxGeneric<int> findMax = new FindMaxGeneric<int>(first, second, third);
            findMax.TestMaximum();

            Console.ReadLine();
        }
    }
}
