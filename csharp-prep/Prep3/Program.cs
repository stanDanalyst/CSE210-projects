using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("This is a guess a number (between 1 - 200) game. ");
        Console.WriteLine();

        //Generate random number.
        Random number = new Random();
        int newNumber = number.Next(1, 200);

        //Variables.
        int newGuess = -1;
        int numbGuess = 1;
        string resp1 = "YES";
        string resp2 = "NO";

        //Loop until user guess the number right.
        while (newGuess != newNumber)
           
        {
          
           Console.Write("What is your guess? ");
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
                Console.WriteLine();
               Console.WriteLine("Congratulations, you guessed it!");
               Console.WriteLine($"It took you: {countGuess} guesses");
               Console.WriteLine();

                //Check if user wants to play again.
                Console.Write("Do you want to play again (yes/no) ? ");
              
                string playAgain = Console.ReadLine();

                string upperCase = playAgain.ToUpper();
                 Console.WriteLine();

                if (upperCase == resp1)
                {
                    newNumber = number.Next(1, 101);
                }
                else if (upperCase == resp2)
                {
                    Console.WriteLine("Sounds good, see you next time!");
                    Console.WriteLine();
                }
           }       
     }   
    }
}