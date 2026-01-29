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

            //First Number
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
                catch (Exception)
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

            //Second Number
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
                    message = $"Good job! {secondNumber} is a number!";

                }
                catch (Exception)
                {
                    if (userinput == "Q" || userinput == "q")
                    {
                        Console.WriteLine("Have a nice day!");
                        isValid = true;
                    }

                    else
                    {
                        Console.WriteLine($"{userinput} is not a number");
                        isValid = false;
                    }
                }

            }
            while (isValid == false);

            message = $"Good job! {secondNumber} is a number!";

            //Third Number
            do
            {
                Console.WriteLine("Please enter a number to select how you'd like to solve! (1-4)");
                Console.WriteLine("Enter \"Q\" to exit");
                userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case "2":
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case "3":
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case "4":
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                        break;
                }

                try
                {
                    // risky code
                    thirdNumber = int.Parse(userinput);
                    isValid = true;
                    message = $"Good job! {thirdNumber} is a number!";

                }
                catch (Exception)
                {
                    if (userinput == "Q" || userinput == "q")
                    {
                        Console.WriteLine("Have a nice day!");
                        isValid = true;
                    }

                    else
                    {
                        Console.WriteLine($"{userinput} is not a number");
                        isValid = false;
                    }
                }

            }
            while (isValid == false);

            message = $"Good job! {thirdNumber} is a number!";

            //Pause
            Console.Read();

        }
    }
}

