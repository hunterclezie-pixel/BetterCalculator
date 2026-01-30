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
            bool userQuit = false, validResponse = false;

            do
            {
                //First Number
                do
                {
                    Console.WriteLine("Please enter your first number");
                    Console.WriteLine("Enter \"Q\" to exit");
                    userinput = Console.ReadLine();
                    Console.WriteLine($"You enter {userinput}");

                    try
                    {
                        Console.WriteLine($"you entered {int.Parse(userinput)}");
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
                            Console.WriteLine($"{userinput} is not a number");
                        }

                    }
                } while (validResponse == false && userQuit == false);

                Console.WriteLine("end of first loop");

                //Second number
                validResponse = false; //reset flag
                while (validResponse == false && userQuit == false)
                {
                    Console.WriteLine("Please enter your second number");
                    Console.WriteLine("Enter \"Q\" to exit");
                    userinput = Console.ReadLine();
                    Console.WriteLine($"You enter {userinput}");

                    try
                    {
                        secondNumber = int.Parse(userinput);
                        Console.WriteLine($"you entered {int.Parse(userinput)}");
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
                            Console.WriteLine($"{userinput} is not a number");
                        }

                    }
                }

                Console.WriteLine("end of second loop");

                //Operation Choice
                validResponse = false; //reset flag
                while (validResponse == false && userQuit == false)
                {
                    validResponse = true; //option selection reset
                    Console.WriteLine("Please select a choice: \n 1. Addition \n 2. Subtraction \n 3. multiplication \n 4. division");
                    userinput = Console.ReadLine();
                    thirdNumber = int.Parse(userinput);

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

