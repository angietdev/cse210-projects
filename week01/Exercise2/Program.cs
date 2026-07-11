using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine ("What is your grade percentage?");
       string gradeFromUser = Console.ReadLine ();
       int Percent = int.Parse (gradeFromUser);
       string grade = "";

       if ( Percent >= 90)
        {
            grade = "A";
        }
        else if (Percent >= 80)
        {
            grade = "B";
        }
        else if (Percent >= 70)
        {
            grade = "C";
        }
        else if (Percent >= 60)
        {
            grade ="D";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine ($"your grade is: {grade}");
        
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