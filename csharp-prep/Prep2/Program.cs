using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Get grade percentage from a user
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        //Convert string to int
        int newGrade = int.Parse(grade);
        char letter;

        //Logic to used to identify grade.
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
        char sign;

        //Logic for + or negative sing
        int remender = newGrade % 10;

        if (remender >= 7 && newGrade > 60 && newGrade < 90)
        {
            sign = '+';
        }
        else if (remender <= 6 && newGrade > 60 && newGrade < 93)
        {
            sign = '-';
        }
        else
        {
            sign = ' ';
        }

        //Print grade to the screen
        Console.WriteLine($"Your grade is {letter}{sign}");

        //Check if user passed or failed the class
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