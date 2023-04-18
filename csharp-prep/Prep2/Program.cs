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

      if (scoreNumber >= 90)
      {
        if (scoreNumber % 10 >= 3 || scoreNumber >= 100)
        {
            Console.WriteLine("Grade is A");
        }
        else
        {
            Console.WriteLine("Grade is A-");
        }
      }
      else if (scoreNumber >= 80)
      {
        if (scoreNumber % 10 >= 7)
        {
            Console.WriteLine("Grade is B+");
        }
        else if (scoreNumber % 10 < 3)
        {
            Console.WriteLine("Grade is B-");
        }
        else
        {
            Console.WriteLine("Grade is B");
        }
      }
      else if (scoreNumber >= 70)
      {
        if (scoreNumber % 10 >= 10)
        {
            Console.WriteLine("Grade is C+");
        }
        else if (scoreNumber % 10 < 3)
        {
            Console.WriteLine("Grade is C-");
        }
        else
        {
             Console.WriteLine("Grade is C");
        }
       
      }
      else if (scoreNumber >= 60)
      {
        if (scoreNumber % 10 >= 7)
        {
            Console.WriteLine("Grade is D+");
        }
        else if (scoreNumber % 10 < 3)
        {
            Console.WriteLine("Grade is D-");
        }
        else
        {
            Console.WriteLine("Grade is D");
        }
      }
      else
      {
        Console.WriteLine("Grade is F");
      }
      if (scoreNumber >= 70)
      {
        Console.WriteLine("You passed!");
      }
      else
      {
        Console.WriteLine("Sorry you did not make it.");
      }


    }
}