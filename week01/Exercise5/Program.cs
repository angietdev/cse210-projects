using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        string userName = PromptUserName();

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int userNumber = int.Parse(number);
            return userNumber;
        }
        int userNumber = PromptUserNumber();

        static int SquareNumber(int Usernumber)
        {
            return Usernumber * Usernumber;
        }
        int squaredNumber = SquareNumber(userNumber);

        static void DisplayResult (string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
        }
        DisplayResult(userName, squaredNumber);
    }
}