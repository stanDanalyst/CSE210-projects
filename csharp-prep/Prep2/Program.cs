using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Get grade percentage from a user
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int newGrade = int.Parse(grade);
        char letter;

        if (newGrade >= 90)
       
        {
            
            letter = 'A';
        }
        else if (newGrade >= 80 && newGrade != 90)
        {
            letter = 'B';
        }
        else if (newGrade >= 70 && newGrade != 80)
        {
            letter = 'C';
        }
        else if (newGrade >= 60 && newGrade != 70)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"Your grade is {letter}");

        int passClass = newGrade;

        if (passClass >= 70)
        {
            Console.WriteLine($"Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine($"Sorry, you did not pass. Try again!");
        }
    }
}