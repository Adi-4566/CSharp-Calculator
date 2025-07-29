using System;

namespace CalculatorProgram
{
    class Calculator
    {
        static void Main()
        {
            char operation;
            string selection;
            bool yes = true;
            double num1;
            double num2;
            double answer;

            while (yes)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("\n\tCALCULATOR PROGRAM\n");
                Console.WriteLine("==================================");

                Console.WriteLine("\nChoose a operation you want to use : \n");
                Console.WriteLine("\tType (+) for ADDITION");
                Console.WriteLine("\tType (-) for SUBTRACTION");
                Console.WriteLine("\tType (*) for MULTIPLICATION");
                Console.WriteLine("\tType (/) for DIVISION");

                Console.Write("\nyou chose : ");
                operation = Convert.ToChar(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        Console.WriteLine("\t\t(ADDITION)");
                        break;
                    case '-':
                        Console.WriteLine("\t\t(SUBTRACTION)");
                        break;
                    case '*':
                        Console.WriteLine("\t\t(MULTIPLICATION)");
                        break;
                    case '/':
                        Console.WriteLine("\t\t(DIVISION)");
                        break;
                    default:
                        Console.WriteLine("\nWRONG INPUT. TRY AGAIN\n");
                        break;
                }

                while (operation != '+' && operation != '-' && operation != '*' && operation != '/')
                {
                    Console.Write("\nyou chose : ");
                    operation = Convert.ToChar(Console.ReadLine());
                    switch (operation)
                    {
                        case '+':
                            Console.WriteLine("\t\t(ADDITION)");
                            break;
                        case '-':
                            Console.WriteLine("\t\t(SUBTRACTION)");
                            break;
                        case '*':
                            Console.WriteLine("\t\t(MULTIPLICATION)");
                            break;
                        case '/':
                            Console.WriteLine("\t\t(DIVISION)");
                            break;
                        default:
                            Console.WriteLine("\nWRONG INPUT. TRY AGAIN\n");
                            break;
                    }
                }

                Console.Write("\nEnter the first operand : ");
                while(!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid number. Enter a valid number : ");
                }
                Console.Write("Enter the second operand : ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid number. Enter a valid number : ");
                }

                    switch (operation)
                    {
                    case '+':
                        answer = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + answer);
                        Console.WriteLine("\nThe aswer is " + answer);
                        break;
                    case '-':
                        answer = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + answer);
                        Console.WriteLine("\nThe aswer is " + answer);
                        break;
                    case '*':
                        answer = num1 * num2;
                        Console.WriteLine(num1 + " * " + num2 + " = " + answer);
                        Console.WriteLine("\nThe aswer is " + answer);
                        break;
                    case '/':
                        answer = num1 / num2;
                        while (num2 == 0)
                        {
                            Console.WriteLine("cannot divide by zero!");
                            Console.Write("\nEnter the second operand : ");
                            while (!double.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.Write("Invalid input. Enter a valid number : ");
                            }
                            answer = num1 / num2;
                        }
                        Console.WriteLine(num1 + " / " + num2 + " = " + answer);
                        Console.WriteLine("\nThe answer is " + answer);
                        break;
                    }
                do
                {
                    Console.WriteLine("\nPress (Y) if you want solve more");
                    Console.WriteLine("Press (N) if you want to stop");
                    Console.Write("You select : ");
                    selection = Console.ReadLine().ToUpper();
                    yes = (selection == "Y");

                } while (selection != "Y" && selection != "N");
            }

            Console.WriteLine("\nThank you for using the calculator!");

            Console.ReadKey();
        }
    }
}
