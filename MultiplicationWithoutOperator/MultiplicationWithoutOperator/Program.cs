using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationWithoutOperator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("First number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = multiply(num1, num2);
            Console.WriteLine($"{num1} X {num2} = {result}");
            Console.ReadKey();
        }

        public static int multiply(int num1, int num2)
        {
            int result = 0;
            for(var i = 0; i < num2; i++)
            {
                result += num1;
            }
            return result;
        }
    }
}
