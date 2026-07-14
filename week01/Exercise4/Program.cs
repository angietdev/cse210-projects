using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
     List<int> number = new List<int>();
     int userNumber;
     Console.WriteLine ("Enter a list of numbers, type 0 when finished");
     do
     {
        Console.Write ("Enter a number: ");
        string userResponse = Console.ReadLine ();
        userNumber = int.Parse (userResponse);
        number.Add (userNumber);

     } while (userNumber != 0);

    int sum = 0;
        foreach (int num in number)
            {
            sum += num;   
            }
            Console.WriteLine ($"The sum of the numbers is: {sum}");

    float average = (float)sum / (number.Count-1);
        Console.WriteLine ($"The average of the numbers is: {average}");

    int max = number[0];
        foreach (int num in number)
            {
            if (num > max)
                {
                max = num;
                }
            }
            Console.WriteLine ($"The maximum number is: {max}");

    }
    
}