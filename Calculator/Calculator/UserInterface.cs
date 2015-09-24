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
            double number1 = GetNumber();
            string operator1 = GetOperator();
            double number2 = GetNumber();
            switch (operator1)
            {
                case "+":
                    Console.WriteLine("= " + calculator.Add(number1, number2));
                    break;
                case "-":
                    Console.WriteLine("= " + calculator.Subtract(number1, number2));
                    break;
                case "*":
                    Console.WriteLine("= " + calculator.Multiply(number1, number2));
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine("= " + calculator.Divide(number1, number2));
                    }
                    catch (System.DivideByZeroException e)
                    {
                        Console.WriteLine("You Can't Divide By 0 MORON!!! " + e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Stop Hacking the Calculator");
                    break;
            }
        }
        private double GetNumber()
        {
            double number;
            Console.WriteLine("Enter a number: ");
            try
            {
                number = Convert.ToDouble(Console.ReadLine());
                //Console.Beep();
                return number;
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("Please enter a valid number " + e.Message);
                return GetNumber();
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Please enter a valid number " + e.Message);
                return GetNumber();
            }
        }
        private string GetOperator()
        {
            string operator1;
            Console.WriteLine("Enter an operator: ");
            operator1 = Console.ReadLine();
            //Console.Beep();
            switch (operator1)
            {
                case "+":
                    return operator1;
                case "-":
                    return operator1;
                case "*":
                    return operator1;
                case "/":
                    return operator1;
                default:
                    return GetOperator();
            }

        }

    }
}
