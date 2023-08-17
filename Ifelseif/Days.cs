using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifelseif
{
    internal class Days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("select 0 to 6");
            int op=Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 0:
                    Console.WriteLine("sunday selected");
                    break;

                case 1:
                    Console.WriteLine("monday selected");
                    break;

                case 2:
                    Console.WriteLine("tuesday selected");
                    break;

                case 3:
                    Console.WriteLine("wednesday selected");
                    break;

                case 4:
                    Console.WriteLine("thursday selected");
                    break;

                case 5:
                    Console.WriteLine("friday selected");
                    break;

                case 6:
                    Console.WriteLine("saturday selected");
                    break;

                default:
                    Console.WriteLine("wrong option");
                    break;
            }
        }
    }
}
