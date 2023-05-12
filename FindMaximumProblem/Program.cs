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
            float first = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter second value:");
            float second = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter third value:");
            float third = Convert.ToSingle(Console.ReadLine());

            FindMaxGeneric<float> findMax = new FindMaxGeneric<float>(first, second, third);
            findMax.TestMaximum();

            Console.ReadLine();
        }
    }
}
