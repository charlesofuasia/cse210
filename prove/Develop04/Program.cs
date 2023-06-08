using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wellcome to the Mindfullness App");
        Console.WriteLine();
         string option = "";

           while(option != "4")
           {
             option = ChooseOption();
            switch(option){
            case "1":
            BreathingActivity breathing = new BreathingActivity();
            breathing.RunBreathingActivity();
            break;

            case "2":
            ListingActivity listing = new ListingActivity();
            listing.RunListingActivity();
            break;

            case "3":
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.RunReflectionActivity();
            break;

            case "4":
            break;

            default:
            Console.WriteLine("Please enter only numerical values 1 - 4");
            break;
        };
         }
         Console.WriteLine();
         Console.WriteLine("Thank you for using the app. Goodbye!");
            
        static string ChooseOption()
        {
            Console.Clear();
            Console.WriteLine("Choose one option from this list:");
            Console.WriteLine("1. Breathing.\n2. Listing.\n3. Reflection.\n4. Exit");
            string option = Console.ReadLine();
            return option;
        }
    }
}