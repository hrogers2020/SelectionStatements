using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 7;

            Console.WriteLine("Guess my favorite number. Hint: below 12");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("Too LOW!!!");
            }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("Too HIGH!!!");
            }
            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("You are correct: Here is a cookie!");
            }
            else
            {
                Console.WriteLine("Nevermind"); 
            }
        }
    }
}
