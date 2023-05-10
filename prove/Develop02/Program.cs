using System;

class Program
{
    static void Main(string[] args)
    {
    //new instance PromptGenerator created and values assigned to  its attributes.
        PromptGenerator _prompt = new PromptGenerator();
        _prompt._dayLessonPrompt = "What is the most important lesson you learnt today?";
        _prompt._dayTasksPrompt = "Which important tasks did you carry out today?";
        _prompt._improvementPrompt = "What did you do today that perhaps you can improve upon?";
        _prompt._remarkableEventPrompt = "What do you consider the most remarkable event of today?";
        _prompt._remarkablePersonprompt = "Was there a remarkable person you met today?";
        _prompt._scripturePrompt = "What did you learn from the scriptures study today?";

//date variable created to from Datetime class to generate dates of entries.
         DateTime date = DateTime.Today;

         ChooseAction();
//new Entry 
        Entry newEntry = new Entry();
        newEntry._date = date.ToString();
        newEntry._entryPrompt = _prompt.GenerateRandomPrompt();
        Console.WriteLine(newEntry._entryPrompt);
        newEntry._entry = Console.ReadLine();
        newEntry.CreateNewEntry();



        static void ChooseAction()
        {
            Console.WriteLine("1. Make a new entry in the journal");
            Console.WriteLine("2. View past journal entries.");
            Console.WriteLine("3. Exit the journal app.");
            Console.Write("What would you like to do? Choose 1 - 3.:    ");
            string option = Console.ReadLine();
            Console.WriteLine();
        }
        


    }
}