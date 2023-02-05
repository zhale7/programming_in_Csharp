using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLessonOfProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.Write("Enter the first number: ");
            int first_number,
                second_number;
            while(true)
            {
                try
                {
                    first_number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("You can only enter int type number");
                }
            }
            
            Console.Write("Enter the second number: ");
            while(true)
            {
                try
                {
                    second_number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("You can only enter int type number");
                }
            }
            
            int result = Sum(first_number, second_number);
            Console.WriteLine("Sum is: " + result);
            Console.WriteLine("Great!The result is ready");
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
