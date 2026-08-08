using System;
using System.Threading;

class Program
{

// EXCEEDS REQUIREMENTS:
// I added input validation to the main menu.
// If the user enters an invalid option, the program displays
// an error message instead of silently doing nothing.

static void Main(string[] args)
{
string choice = "";

    while (choice != "4")
    {
        Console.Clear();

        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");

        choice = Console.ReadLine();

        if (choice == "1")
        {
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();
        }
        else if (choice == "2")
        {
            ReflectingActivity reflecting = new ReflectingActivity();
            reflecting.Run();
        }
        else if (choice == "3")
        {
            ListingActivity listing = new ListingActivity();
            listing.Run();
        }
        else if (choice != "4")
        {
            Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
            Thread.Sleep(2000);
        }
    }

    Console.WriteLine("Goodbye!");
}

}
