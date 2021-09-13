using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("Welcome to Hangman");
            Console.WriteLine("Enter a Letter or Word");

            string randomWord = "Marshmallow";
            string guess = "";
            int guessNumber = 0;
            int guessLimit = 10;
            bool noMoreguesses = false;

            while (guess != randomWord && !noMoreguesses)

                if (guessNumber < guessLimit)
                {

                    Console.Write("Submit guess");
                    guess = Console.ReadLine();
                    guessNumber++;
                }
                else
                {
                    noMoreguesses = true;
                }
                if (noMoreguesses)
                {
                Console.WriteLine(" You Lose!");
                } 
                else
                {
                Console.WriteLine("You Win!");
                }
                
                

                Console.ReadLine(); 

        }
    }
}
