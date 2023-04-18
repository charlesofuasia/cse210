using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string FirstName = Console.ReadLine();
        Console.Write("What is your surname? ");
        string Surname = Console.ReadLine();
        //Use char function and Toupper method to capitalize output in cases where user input are in lower cases
        Console.WriteLine($"Your name is {char.ToUpper(Surname[0]) + Surname.Substring(1)},  {char.ToUpper(FirstName[0]) + FirstName.Substring(1)} {char.ToUpper(Surname[0]) + Surname.Substring(1)}.");
       
    }
}