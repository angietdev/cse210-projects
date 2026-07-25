using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*
        CREATIVITY:
        I added a small scripture library so the program can randomly select
        a different scripture each time it runs. I also made the program
        hide only words that are still visible and added support for
        punctuation when displaying hidden words.
        */

        List<Scripture> library = new List<Scripture>
        {
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),

            new Scripture(
                new Reference("Joshua", 1, 9),
                "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest."
            ),

            new Scripture(
                new Reference("Proverbs", 16, 3),
                "Commit thy works unto the Lord, and thy thoughts shall be established."
            )
        };

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        string userInput = "";

        while (userInput.ToLowerInvariant() != "quit" &&
               !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine() ?? "";

            if (userInput.ToLowerInvariant() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nAll words have been hidden. Good job memorizing!");
        }
    }
}