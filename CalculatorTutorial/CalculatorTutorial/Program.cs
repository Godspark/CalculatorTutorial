using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var argument in args)
            {
                Console.WriteLine(argument);
            }

            //int tall1 = 7;
            //int tall2 = 9;

            //int sum = tall1 + tall2;
            //Console.WriteLine(tall1 + " + " + tall2 + " = " + sum); // 7 + 9 = 16

            //string input = string.Empty;

            //while(!input.Equals("exit", StringComparison.InvariantCultureIgnoreCase)) 
            //{
            //    input = Console.ReadLine();
            //}

            string input1 = string.Empty;
            string input2 = string.Empty;

            while (!(input1.Equals("exit", StringComparison.InvariantCultureIgnoreCase) || input2.Equals("exit", StringComparison.InvariantCultureIgnoreCase)))
            {
                try
                {
                    Console.Write("First: ");
                    input1 = Console.ReadLine();
                    int inputTall1 = int.Parse(input1);

                    Console.Write("Second: ");
                    input2 = Console.ReadLine();
                    int inputTall2 = int.Parse(input2);

                    Console.Write("Sum: ");
                    int inputSum = inputTall1 + inputTall2;
                    Console.WriteLine(inputSum);
                }
                catch (FormatException e)
                {
                    if (!(input1.Equals("exit", StringComparison.InvariantCultureIgnoreCase) || input2.Equals("exit", StringComparison.InvariantCultureIgnoreCase)))
                        Console.WriteLine("That was not a number!");                    
                }

            }


            Console.WriteLine("Thanks for trying my calculator! Press enter to exit.");
            Console.ReadLine();
        }
    }
}
