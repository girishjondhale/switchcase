using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifelseif
{
    internal class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first num");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("second num");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("select operation");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    int add = n1 + n2;
                    Console.WriteLine($"addition is {add}");
                    break;

                case 2:
                    int sub = n1 - n2;
                    Console.WriteLine($"substraction is {sub}");
                    break;

                case 3:
                    int mul = n1 * n2;
                    Console.WriteLine($"multiplication is {mul}");
                    break;

                case 4:
                    int div = n1 / n2;
                    Console.WriteLine($"division is {div}");
                    break;

                case 5:
                    int mod = n1 % n2;
                    Console.WriteLine($"modulus is {mod}");
                    break;

                default:
                    Console.WriteLine("wrong option");
                    break;
            }

        }
    }
}
