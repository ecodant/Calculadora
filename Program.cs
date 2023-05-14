using System;

namespace Calculator_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            start_Menu();

             void start_Menu()
            {
                bool sentinel = true;
                do
                {
                    int user_Input;
                    Console.WriteLine("Welcome to the Calculator\n Please enter the option that you want\n Enter the option to the start to use the Calculator");
                    Console.WriteLine("1. To Sum\n2. To Substract\n3. To Multiply\n4. To Divied\n");

                    if (Int32.TryParse(Console.ReadLine(), out user_Input))
                    {
                        switch (user_Input)
                        {
                            case 1:
                                calculator.sum_Calculator();
                                break;
                            case 2:
                                calculator.substract_Calculator();
                                break;
                            case 3:
                                calculator.multiply_Calculator();
                                break;
                            case 4:
                                calculator.divide_Calculator();
                                break;
                            default:
                                Console.WriteLine("That option isn't include into the Menu.");
                                break;
                        }
                        sentinel = false;

                    }
                    else
                    {
                        Console.WriteLine("The ingress value isn't validate, try again");
                    }
                } while (sentinel);
            }
        }
    }
}
