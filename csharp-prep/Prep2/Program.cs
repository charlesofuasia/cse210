using System;

class Program
{
    static void Main(string[] args)
    {
      // to classify a given score into a grade
      //get raw score input from user
      Console.Write("Enter a score: ");
      string score = Console.ReadLine();
      //convert string input to an integer
      int scoreNumber = int.Parse(score);

      string letter = "";
      string highlight = "";
      if (scoreNumber >= 90)
      {
        letter = "A";
      }
      else if (scoreNumber >= 80)
      {
        letter = "B";
      }
      else if (scoreNumber >= 70)
      {
        letter = "C";
      }
      else if (scoreNumber >= 60)
      {
        letter = "D";
      }
      else
      {
        letter = "F";
      }
      // Stretch assignment appending + and - to grades as required.
      if (scoreNumber < 90 && scoreNumber >= 60)
      {
        if (scoreNumber % 10 >= 7)
        {
          highlight = "+";
        }
        else if (scoreNumber % 10 < 3)
        {
          highlight = "-";
        }
      }
      else if (scoreNumber >=90)
      {
        if (scoreNumber % 10 < 3 && scoreNumber <= 100)
        {
          highlight = "-";
        }
      }
      Console.WriteLine($"Your grade is {letter}{highlight}");

      if (scoreNumber >= 70)
      {
        Console.WriteLine("Congrats, you passed!");
      }
      else
      {
        Console.WriteLine("Sorry, you did not make it. Better luck next time.");
      }

    }
}