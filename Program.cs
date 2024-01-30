using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Grade Evaluator!");

        // Input grade from the user
        Console.Write("Enter your grade (A, B, C, D, or F): ");
        char grade = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Evaluate the grade
        if(grade == 'A')
        {
            Console.WriteLine("Excellent!");
        }
        else if(grade == 'B')
        {
            Console.WriteLine("Well done!");
        }
        else if(grade == 'C')
        {
            Console.WriteLine("Good job!");
        }
        else if(grade == 'D')
        {
            Console.WriteLine("You passed.");
        }
        else if(grade == 'F')
        {
            Console.WriteLine("Better luck next time.");
        }
        else
        {
            Console.WriteLine("Invalid grade entered.");
        }
    }
}
