namespace calucaltor
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool repeateCalculation = false;
        
            do
            {
                Console.Clear();
                Console.WriteLine("-----------Calculator------------");

                Console.WriteLine();
                // Select operator
                bool isValidOperator = false;

                Console.WriteLine("Select one of those operators---");
                Console.WriteLine("Press +   For Addision");
                Console.WriteLine("Press -   For Substraction");
                Console.WriteLine("Press *   For Multiplication");
                Console.WriteLine("Press /   For Division");


                string? myOperator = Console.ReadLine();
                Console.WriteLine();
                do
                {
                    switch (myOperator)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                            isValidOperator = true;
                            break;
                        default:
                            Console.Beep();
                            Console.WriteLine("this is not a valid operator.......!");
                            Console.WriteLine();

                            Console.WriteLine("Select one of those operators---");
                            Console.WriteLine("Press +   For Addision");
                            Console.WriteLine("Press -   For Substraction");
                            Console.WriteLine("Press *   For Multiplication");
                            Console.WriteLine("Press /   For Division");

                            myOperator = Console.ReadLine();
                            isValidOperator = false;
                            break;

                    }

                } while (!isValidOperator);

                Console.WriteLine();


                Console.Write("Enter the first number: ");
                double num1;

                bool isNumber1 = double.TryParse(Console.ReadLine(),out num1);

                while (!isNumber1)
                {
                    Console.Beep();
                    Console.WriteLine("Sorry this is not a valid number try another input...!");
                    Console.WriteLine();
                    Console.Write("Enter the first number: ");
                    isNumber1 = double.TryParse(Console.ReadLine(),out num1);
                }
                Console.Write("Enter the second number: ");

                double num2;

                bool isNumber2 = double.TryParse(Console.ReadLine(),out num2);

                while (!isNumber2)
                {
                    Console.Beep();
                    Console.WriteLine("Sorry this is not a valid number try another input...!");
                    Console.WriteLine();
                    Console.Write("Enter the second number: ");
                    isNumber2 = double.TryParse((Console.ReadLine()),out num2);
                }
                Console.WriteLine();

                while (myOperator == "/" && num2 == 0)
                {
                    Console.WriteLine("Number 2 is not valid to division...!");
                    Console.Write("Enter another number 2: ");

                    isNumber2 = double.TryParse(Console.ReadLine(), out num2);

                    while (!isNumber2)
                    {
                        Console.WriteLine("Sorry this is not a valid number try another input...!");
                        Console.WriteLine();
                        isNumber2 = double.TryParse((Console.ReadLine()), out num2);
                    }

                }



                // Calculate result
                string result = "Result =";

                switch (myOperator)
                {

                    case "+":
                        Console.WriteLine($"{result} {num1 + num2}");
                        break;

                    case "-":
                        Console.WriteLine($"{result} {num1 - num2}");
                        break;

                    case "*":
                        Console.WriteLine($"{result} {num1 * num2}");
                        break;

                    case "/":
                        Console.WriteLine($"{result} {num1 / num2}");
                        break;


                    default:
                        // It will not happend because it has already checked.....!
                        Console.WriteLine("Wrong operator....!");
                        break;

                }


                Console.WriteLine();
                Console.WriteLine("Do you want to another claculation......(y / n)");
                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine();

                while (answer != 'y' && answer != 'n')
                {
                    Console.WriteLine("sorry I didn't understand please select y or n");
                    answer = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }


                switch (answer)
                {
                    case 'y':
                        repeateCalculation = true;
                        break;

                    default:
                        repeateCalculation = false;
                        Console.WriteLine("Thank you using clucaltor ..... GoodBye :)");
                        break;
                }


            } while (repeateCalculation);




        }
    }
}