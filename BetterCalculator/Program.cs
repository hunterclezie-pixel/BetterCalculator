/* 
Hunter Clezie 
Spring 2026
RCET2265
BetterCalculator
github url: https://github.com/hunterclezie-pixel/BetterCalculator.git
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
            bool userQuit = false, validResponse = false;
            
            do
            {
                //First Number
                do
                {
                    Console.WriteLine("Welcome! Please enter your first number");
                    Console.WriteLine("Enter \"Q\" to exit whenever you'd Like");
                    userinput = Console.ReadLine();
                    Console.Clear();

                    try
                    {
                        Console.WriteLine($"you entered {int.Parse(userinput)} as your first number");
                        firstNumber = int.Parse(userinput);
                        validResponse = true;
                    }
                    catch (Exception)
                    {
                        if (userinput == "Q" || userinput == "q")
                        {
                            userQuit = true;
                        }

                        else
                        {
                            Console.WriteLine($"{userinput} is not a number, please try again");
                        }

                    }
                } while (validResponse == false && userQuit == false);

                //Second number
                validResponse = false; //reset flag
                while (validResponse == false && userQuit == false)
                {
                    Console.WriteLine("Please enter your second number");
                    Console.WriteLine("Enter \"Q\" to exit whenever you'd Like!");
                    userinput = Console.ReadLine();
                    Console.Clear();

                    try
                    {
                        secondNumber = int.Parse(userinput);
                        Console.WriteLine($"you entered {int.Parse(userinput)} as your second number");
                        validResponse = true;
                    }
                    catch (Exception)
                    {
                        if (userinput == "Q" || userinput == "q")
                        {
                            userQuit = true;
                        }

                        else
                        {
                            Console.WriteLine($"{userinput} is not a number, please try again");
                        }

                    }
                }

                //Operation Choice
                validResponse = false; //reset flag
                while (validResponse == false && userQuit == false)
                {
                    validResponse = true; //option selection reset
                    Console.WriteLine("Please select how you would like to solve: \n 1. Addition \n 2. Subtraction \n 3. multiplication \n 4. division");
                    userinput = Console.ReadLine();
                    Console.Clear();
                    thirdNumber = int.Parse(userinput);

                    switch (userinput)
                    {
                        case "1":
                            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}"); //addition
                            break;
                        case "2":
                            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}"); //subtraction
                            break;
                        case "3":
                            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}"); //multiplication
                            break;
                        case "4":
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}"); //division
                            break;

                        case "Q":
                            userQuit = true;
                            break;

                        case "q":
                            userQuit = true;
                            break;

                        default:
                            Console.WriteLine($"{userinput} is not an option, please try again!");
                            validResponse = false;
                            break;
                    }
                }

            } while (userQuit == false);
            {
                Console.WriteLine("Have a great day!");
            }

            //pause
            Console.Read();
        }
    }
}

