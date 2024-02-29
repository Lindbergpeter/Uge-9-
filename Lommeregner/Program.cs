using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.Quic;

namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            double sum = 0;
            bool isCalculatorOn = true;
            string quit = "";



            Console.WriteLine("Calculator!");

            while (isCalculatorOn)
            {
                Console.WriteLine("Do you wish to Add,Subtract,Divide or Multiply? Type your answer");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("/");
                Console.WriteLine("*");

                string choice = Console.ReadLine().ToLower();

                if ((choice == "+") || (choice == "-") || (choice == "/") || (choice == "*"))
                {
                    try
                    {
                        Console.WriteLine("Enter X");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Y");
                        int y = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case "+":
                                sum = calculator.Add(x, y);
                                break;

                            case "-":
                                sum = calculator.Subtract(x, y);
                                break;
                            case "/":
                                sum = calculator.Divide(x, y);
                                break;
                            case "*":
                                sum = calculator.Multiply(x, y);
                                break;
                        }
                        Console.WriteLine($"{x} {choice} {y} = {sum}");

                        Console.WriteLine("Press enter to run the program again, or Q to quit");
                        quit = Console.ReadLine();

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter only numbers");

                        Console.Write("Press enter to run the program again, or Q to quit");
                        quit = Console.ReadLine();
                    }

                }else    
               {
                    Console.WriteLine("Only enter +, -, / or *");
                }

                if (quit == "q") isCalculatorOn = false;
                Console.Clear();
            }
        }
    }
}
