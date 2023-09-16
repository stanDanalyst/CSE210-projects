using System;

class Program
{
    static void Main(string[] args)
    {

        int newNumber = 55;

        int newGuess = -1;

        while (newGuess != newNumber)
           
        {

           Console.WriteLine("What is your guess? ");
           //Get user number guess
           newGuess = int.Parse(Console.ReadLine());

           if (newGuess > newNumber)
           {
               Console.WriteLine("Higher");
    
           }


           else if (newGuess < newNumber)
           {
               Console.WriteLine("Lower");

           }
           else
           {
               Console.WriteLine("You guessed it!");
           }


     }
        
    }
}