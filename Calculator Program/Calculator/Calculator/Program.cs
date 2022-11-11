using System;

namespace CalcProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int x = 1;
            do
            {
               
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------------");
                Console.WriteLine("Calculator Program V-1.0");
                Console.WriteLine("------------------------");

                Console.WriteLine("Enter number 1: ");
                string num1string = Console.ReadLine();
                if (Double.TryParse(num1string, out num1) )
                {
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\t\t\t" + "Inputted value is not a valid number -___-");
                    x--;

                }


                Console.WriteLine("Enter number 2: ");
                string num2string = Console.ReadLine();
                if (Double.TryParse(num2string, out num2))
                {
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\t\t\t" + "Inputted value is not a valid number -___-");
                    x--;
                }
                if(x <= 0)
                {
                    Console.WriteLine("Program will now be closed in 5 secs due to invalid formating");
                    Thread.Sleep(2500);

                    System.Environment.Exit(5);
                }
                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t + : Add");
                Console.WriteLine("\t - : Subtract");
                Console.WriteLine("\t * : Multiply");
                Console.WriteLine("\t / : Divide");
                Console.WriteLine("\t % : Modulo");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;

                    case "%":
                        result = num1 % num2;
                        Console.WriteLine($"Your result: {num1} % {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That is not a valid option");
                        break;
                }
                n--;
                if (n == 0)
                {
                    Console.WriteLine("Do you still want to use the program?");
                    Console.WriteLine("[Y]Yes or [N]No");
                    string choice = Console.ReadLine().ToUpper();
                    if (choice == "N")
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t" + "Thank you for using our program ^__^");
                        n--;

                    }
                    else if (choice == "Y")
                    {
                        n = n + 1;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t" + "Invalid Input -___-");
                        n--;
                    }
                }
            } while (n >= 1);
            
        }
    }
}