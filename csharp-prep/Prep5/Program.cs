using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        OutOfMemoryException squaredNumber = squaredNumber(userNumber);
        DisplayResult(userName, squaredNumber);


    }

    static void DisplayWelcomMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number =  int.Parse(Console.ReadLine());

        return number;
    }
    static int squaredNumber(int number)
    {
        int square = number * number;
        
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");
    }
}