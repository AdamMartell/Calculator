using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class UserInterface
    {
        MathsCalculator calculator = new MathsCalculator();


        public void Display()
        {
            decimal number1 = GetNumber();
            string operator1 = GetOperator();
            decimal number2 = GetNumber();
            if (operator1 == "+")
            {
                Console.WriteLine(calculator.Add(number1, number2));
            }
            else if (operator1 == "-")
            {
                Console.WriteLine(calculator.Subtract(number1, number2));
            }
            else if (operator1 == "/")
            {
                Console.WriteLine(calculator.Divide(number1, number2));
            }
            else if (operator1 == "*")
            {
                Console.WriteLine(calculator.Multiply(number1, number2));
            }
            else
            {
                Console.WriteLine("You are BAD at MATHS.  You Lose!!");
            }
        }
        private decimal GetNumber()
        {
            decimal number;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToDecimal(Console.ReadLine());
            return number;
        }
        private string GetOperator()
        {
            string operator1;
            Console.WriteLine("Enter an operator: ");
            operator1 = Convert.ToString(Console.ReadLine());
            return operator1;
        }

    }
}
