using System;

class Program
{
    static void Main(string[] args)
    {
        //Get users first name.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Get users last name.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        //Line space here
        Console.WriteLine();

        /* Print as message with users firs name and last name */

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}