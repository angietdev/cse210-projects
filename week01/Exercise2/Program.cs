using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine ("What is your grade percentage?");
       string gradeFromUser = Console.ReadLine ();
       int Percent = int.Parse (gradeFromUser);
       string letter = "";

       if ( Percent >= 90)
        {
            letter = "A";
        }
        else if (Percent >= 80)
        {
            letter = "B";
        }
        else if (Percent >= 70)
        {
            letter = "C";
        }
        else if (Percent >= 60)
        {
            letter ="D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine ($"your grade is: {letter}");
        
        if (Percent >= 70)
        {
            Console.WriteLine ("Congratulation you pass!");
        }
        else
        {
            Console.WriteLine ("Don't be afraid you can do it better the next time!");
        }
    }
}