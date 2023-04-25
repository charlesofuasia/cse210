using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program.");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string favNumber = Console.ReadLine();
            int userNumber = int.Parse(favNumber);
            return userNumber;
        }
        static int SquareNumber(int num)
        {
            return (num  * num);
        }

        static void DisplayResult(string userName, int userNumber)
        {
            Console.WriteLine($"Brother {userName}, the square of {userNumber} is {SquareNumber(userNumber)}. ");
        }
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        DisplayResult(userName, userNumber);
    }
}