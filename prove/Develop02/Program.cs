using System;

class Program
{
    static void Main(string[] args)
    {
         //new instance PromptGenerator created and values assigned to  its attributes.
        PromptGenerator prompt = new PromptGenerator();
        prompt._dayLessonPrompt = "What is the most important lesson you learnt today?";
        prompt._dayTasksPrompt = "Which important tasks did you carry out today?";
        prompt._improvementPrompt = "What did you do today that perhaps you can improve upon?";
        prompt._remarkableEventPrompt = "What do you consider the most remarkable event of today?";
        prompt._remarkablePersonprompt = "Was there a remarkable person you met today?";
        prompt._scripturePrompt = "What did you learn from the scriptures study today?";

         // Instance for Journal created here
        Journal journal = new Journal();

        //date variable created to from Datetime class to generate dates of entries.
         DateTime date = DateTime.Today;
         



        // Program flow starts here

        Console.WriteLine("Welcome to your journal app. Choose an option from the list below.");
        Console.WriteLine();

        ListOptions();
        string option = Console.ReadLine();
        Console.WriteLine();

        if( option == "1")
        { 
        
        }
        else if(option == "2")
        {

        }
        else if(option == "3")
        {
            Console.WriteLine("Thank you for using the journal app");
        }
        else
        {
            Console.WriteLine("Please choose from options 1-3 provided.");
            ListOptions();
            option = Console.ReadLine();
            Console.WriteLine();
        }
       



        static void ListOptions()
        {
            Console.WriteLine("1. Make a new entry in the journal");
            Console.WriteLine("2. View past journal entries.");
            Console.WriteLine("3. Exit the journal app.");
            Console.Write("What would you like to do? Choose 1 - 3.:    ");
        
        }
        


    }
}