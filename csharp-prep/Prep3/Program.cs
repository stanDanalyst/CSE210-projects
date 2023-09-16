using System;

class Program
{
    static void Main(string[] args)
    {
        //Generate random number.
        Random number = new Random();
        int newNumber = number.Next(1, 101);

        int newGuess = -1;
        int numbGuess = -1;

        string resp1 = "YES";
        string resp2 = "NO";

        //Loop until user guess the number right.
        while (newGuess != newNumber)
           
        {
          
           Console.WriteLine("What is your guess? ");
           //Get user number guess
           newGuess = int.Parse(Console.ReadLine());
           
           //Count number of times user gueesed.
           int countGuess = numbGuess ++;

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
               Console.WriteLine($"Number of time/s your guessed: {countGuess}");

                Console.WriteLine("Do you want to play again? ");
                string playAgain = Console.ReadLine();

                string upperCase = playAgain.ToUpper();



                if (upperCase == resp1)
                {
                    newNumber = number.Next(1, 101);
                }

                else if (upperCase == resp2)
                {
                    Console.WriteLine("Alright, see you next time");
                }


           }
        


     }
        
    }
}