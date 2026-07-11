using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write ("What is the magic number? ");
        //string userInput = Console.ReadLine();
        //int magicNumber = int.Parse (userInput);

        string response;

        do
        {
        Random number = new Random ();
        int magicNumber = number.Next (1,11);

        Console.Write ("What is your guess? ");
        string userInputGuess = Console.ReadLine();
        int guess = int.Parse (userInputGuess);


        while (guess != magicNumber)
        {   
        if (guess > magicNumber)
        {
            Console.WriteLine ("Lower");
        }
        else
        {
            Console.WriteLine ("Higher");
        }
        Console.Write ("What is your guess? ");
        userInputGuess = Console.ReadLine();
        guess = int.Parse (userInputGuess);
        }
        Console.WriteLine ("You guessed it!");

        Console.Write ("Do you want to contunue? (yes/no)");
        response =Console.ReadLine ();
        }
        while (response == "yes");
    }
    
}