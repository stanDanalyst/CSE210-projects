
using System;

class Program
    {
        static void Main(string[] args)
            {
       
                DisplayWelcome();
                string getName = PromptUserName();
                int getNumber = PromptUserNumber();
                int getSquared = SquareNumber(getNumber);
                
                DisplayResult(getName, getSquared);

            }
            
            static void DisplayWelcome()
                {
                    Console.WriteLine("Welcome to the Program");
                }
            static string PromptUserName()
                {
                    Console.Write("Please enter your first and last name: ");
                    string userName = Console.ReadLine();
                    return userName;
                }
            static int PromptUserNumber()
                {
                    Console.Write("What is your favorite number? ");
                    string enterNumber = Console.ReadLine();
                    int number = int.Parse(enterNumber);
                    return number;
                }
            static int SquareNumber(int number)
                {
                    int squared = number * number;
                    return squared;
                }
            static void DisplayResult(string fName, int number)
                {
                    Console.WriteLine($"{fName}, the square of your number is {number}");
                }
        
        
    }
    



