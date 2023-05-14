using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Git
{
    internal class Calculator
    {
              public void sum_Calculator()
    {
        int sum; 
        int op1 = get_Itanger();
        int op2 = get_Itanger();
        sum = op1 + op2;
        Console.WriteLine($"The operation with the two value is: {sum}");
    }
        private int get_Itanger()
    {
        int user_Input;
        bool sentinel = true;
        do
        {
            Console.WriteLine("Enter the first value to make the operation");
            if (Int32.TryParse(Console.ReadLine(), out user_Input)) sentinel = false;
            else Console.WriteLine("The ingress value isn't validate to Sum Operation, try again");
        } while (sentinel);
        return user_Input;
    }
    }
}
