using System;

class Program
{
    static void Main(string[] arg)
    { 
        int guessNum = 0;

        string playOn = "yes";
       
       while (playOn == "yes")
       {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);
        int count = 0;

          do
        {
           count++;
           Console.Write("Guess the magic number: ");
           string guess = Console.ReadLine();
           guessNum = int.Parse(guess);

           if (magicNum > guessNum)
           {
            Console.WriteLine("Higher.");
           }
           else if (magicNum < guessNum)
           {
            Console.WriteLine("Lower.");
           }
           else
           {
            Console.WriteLine($"You guessed the magic number correctly after {count} attempts.");
           }
           

        } while (guessNum != magicNum);

        Console.Write("Would you like to continue playing? yes/no: ");
        playOn = Console.ReadLine();
       }
    }
}