using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int factorial = 1;
            string text;

            Console.WriteLine("Input a number...");
            text = Console.ReadLine();
            number = int.Parse(text);
            

            for(;number > 0; number--)
            {
                if (number == 0)
                {
                    break;
                }

                if (number > 0)
                {
                    factorial = factorial * number;
                }
                
            }
            

            Console.WriteLine("The factorial of {0} = {1}", text, factorial);
            
            Console.ReadLine();
        }
    }
}
