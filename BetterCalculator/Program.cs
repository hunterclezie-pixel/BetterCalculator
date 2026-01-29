/* 
Hunter Clezie 
Spring 2026
RCET2265
BetterCalculator
github url: 
*/
namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userinput = "";
            int firstNumber, secondNumber, thirdNumber;

            Console.WriteLine("please enter your first number");
            userinput = Console.ReadLine();
            firstNumber = int.Parse(userinput);
            Console.WriteLine($"You entered {firstNumber}");

            Console.WriteLine("please enter your second number");
            userinput = Console.ReadLine();
            secondNumber = int.Parse(userinput);
            Console.WriteLine($"You entered {secondNumber}");

            Console.WriteLine("Please enter a number to select how you'd like to solve! (1-4)");
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
            }

            Console.Read();

        }
    }
}

