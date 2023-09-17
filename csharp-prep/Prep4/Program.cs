using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();

       Console.WriteLine("Enter a list of numbers, type 0 when finished.");
      
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
             string enterNumber = Console.ReadLine();
             number = int.Parse(enterNumber);
            

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }
    
    Console.WriteLine($"The sum is: {sum}");
    Console.WriteLine($"The number of items in the list was: {numbers.Count}");

    float avg = ((float)sum) /numbers.Count;
    Console.WriteLine($"The average is: {avg}");

    int maximum = numbers[0];

    foreach (int n in numbers)
    {
        if (n > maximum)
        {
            maximum = n;
        }
    }
       Console.WriteLine($"The max is: {maximum}");
    }
}