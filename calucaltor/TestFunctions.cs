using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calucaltor
{
    public class TestFunctions
    {
        public static bool CheckOperator(string oprator)
        {
            switch (oprator)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    return true;
                default:
                    Console.Beep();
                    Console.WriteLine("this is not a valid operator.......!");
                    Console.WriteLine();

                    Console.WriteLine("Select one of those operators---");
                    Console.WriteLine("Press +   For Addision");
                    Console.WriteLine("Press -   For Substraction");
                    Console.WriteLine("Press *   For Multiplication");
                    Console.WriteLine("Press /   For Division");

                    return false;


            }

        }


        public static double[] ConvertNumbers(string number1,string number2)
        {
            double num1;

            bool isNumber1 = double.TryParse(number1, out num1);

            if (!isNumber1) throw new ArgumentException();

            double num2;

            bool isNumber2 = double.TryParse(number2, out num2);

            if (!isNumber2) throw new ArgumentException();

            return new double[] { num1, num2 };
        }




        public static double Addition(double num1,double num2)
        {
            return num1 + num2;
        }


        public static double Subtraction(double num1,double num2)
        {
            return num1 - num2;
        }


        public static double Multiplication(double num1,double num2)
        {
            return num1 * num2;
        }


        public static double Division(double num1,double num2)
        {
            if (num2 == 0) throw new ArgumentException();

            return num1 / num2;
        }




    }
}
