/* 
Hunter Clezie 
Spring 2026
RCET2265
BetterCalculator
github url: 
*/
using System.ComponentModel.Design;

namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userinput = "";
            int firstNumber = 0, secondNumber = 0, thirdNumber = 0;
            bool isValid = false;
            string message = "";

            do
            {
                Console.WriteLine("Please enter your first number");
                Console.WriteLine("Enter \"Q\" to exit");
                userinput = Console.ReadLine();
                Console.WriteLine($"You enter {userinput}");

                try
                {
                    // risky code
                    firstNumber = int.Parse(userinput);
                    isValid = true;
                    message = $"Good job! {firstNumber} is a number!";

                }
                catch (Exception ex)
                {
                    if (userinput == "Q" || userinput == "q")
                    {
                        Console.WriteLine("Have a nice day!");
                        isValid = true;
                    }

                    else
                    {
                        Console.WriteLine($"{userinput} is not a number");
                    }
                }

            }
            while (isValid == false);

            message = $"Good job! {firstNumber} is a number!";

            do
            {
                Console.WriteLine("Please enter your second number");
                Console.WriteLine("Enter \"Q\" to exit");
                userinput = Console.ReadLine();
                Console.WriteLine($"You enter {userinput}");

                try
                {
                    // risky code
                    secondNumber = int.Parse(userinput);
                    isValid = true;
                    message = $"Good job! {firstNumber} is a number!";

                }
                catch (Exception ex)
                {
                    if (userinput == "Q" || userinput == "q")
                    {
                        Console.WriteLine("Have a nice day!");
                        isValid = true;
                    }

                    else
                    {
                        Console.WriteLine($"{userinput} is not a number");
                    }
                }

            }
            while (isValid == false);

            message = $"Good job! {secondNumber} is a number!";

            do
            {
                Console.WriteLine("Please enter a number to select how you'd like to solve! (1-4)");
                Console.WriteLine("Enter \"Q\" to exit");
                userinput = Console.ReadLine();
                Console.WriteLine($"You enter {userinput}");

                try
                {
                    // risky code
                    thirdNumber = int.Parse(userinput);
                    isValid = true;
                    message = $"Good job! {thirdNumber} is a number!";

                }
                catch (Exception ex)
                {
                    if (userinput == "Q" || userinput == "q")
                    {
                        Console.WriteLine("Have a nice day!");
                        isValid = true;
                    }

                    else if (userinput = "1")
                    {
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        isValid = true;
                    }

                    else if (userinput = "2")
                    {
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        isValid = true;
                    }

                    else if (userinput = "3")
                    {
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                        isValid = true;
                    }

                    else if (userinput = "4")
                    {
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                        isValid = true;
                    }

                    else
                    {
                        Console.WriteLine($"{userinput} is not a number");
                    }
                }

            }
            while (isValid == false);

            message = $"Good job! {thirdNumber} is a number!";

            Console.Read();

        }
    }
}

