using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Gibbs Patient Information Management System.");
        string department = ChooseDepartment();


        static string ChooseDepartment()
        {
            Console.WriteLine("\nWhat is your role? ");
            Console.WriteLine("1. Front Desk\n2. Optometrist\n3. Dispensing Optician\n4. Accounting\n5. Other");
            Console.Write("Choose any of 1 - 4");
            string department = Console.ReadLine();
            return department;
        }
    }
}