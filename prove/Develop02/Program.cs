using System;
using System.IO;

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
         DateTime date = DateTime.Now;
         



        // Program flow starts here

        Console.WriteLine("Welcome to your journal app. Choose an option from the list below.");
        Console.WriteLine();

        string option = ListOptions();
        
    

        while (option != "4")
        {
            
        if( option == "1")
        { 
            //Create an instance for Entry class
            Entry entry = new Entry();

            //assign current date to _date attribute
            entry._date = date.ToShortDateString();//short of current date assigned to entry._date
            entry._entryPrompt = prompt.GenerateRandomPrompt(); // random prompt is generated here
            Console.WriteLine(entry._entryPrompt);//display random prompt on console
            entry._entry = Console.ReadLine(); //user entry assigned to entry._entry

            journal._entries.Add(entry); //Adds the entry to the _entry list

            //User is then prompted if they wish to save their entry into a file

            Console.Write("Would you like to save your entry? yes = 1, no = 0: ");
            string save = Console.ReadLine();
            Console.WriteLine();

            if (save == "1")
            {
                //Uses SavetoFile method of journal class to save entry filename provided by user.
                 Console.Write("Choose a filename for your journal: ");
                 journal._filename = Console.ReadLine();
                 journal.SaveToFile(journal._filename, journal._entries);
                 Console.WriteLine();

                 Console.WriteLine($"Your entry has been saved to {journal._filename}.");

            }

            else if (save == "0")
            {
                Console.WriteLine("Your entry was not saved.");
                
            }
            else
            {
                Console.WriteLine("You can either choose '1' or '0'");
            }
 

            option = ListOptions();
            
        
        }
        else if(option == "2")
        {
            Console.Write("Choose a filename of the journal you want to view: ");
            journal._filename = Console.ReadLine();

            journal.LoadFromFile(journal._filename);

            option = ListOptions();

        }
        else if (option == "3")
        {
            if ( journal._entries.Count > 0 )
            {
                journal.DisplayJournal();
                option = ListOptions();

            }
            else
            {
                Console.WriteLine("There are no entries in the journal.");
                option = ListOptions();
            }
            
            
        }
       
        else
        {
            Console.WriteLine("Please choose from options 1-3 provided.");
            option = ListOptions();
           
        }

        }

        Console.WriteLine("You have exited the journal app.");

       



        static string ListOptions()
        {
            /*
                Function that shows a list of options to a journal user and prompts 
                the user to choose an option from the list and returns the option 
                choosen by the user.
                Parameters: none
                Returns: option.
            */

            Console.WriteLine("1. Make a new entry in the journal");
            Console.WriteLine("2. View past journal entries from a file.");
            Console.WriteLine("3. Display current journal entries");
            Console.WriteLine("4. Exit the journal app.");
            Console.Write("What would you like to do? Choose 1 - 4: ");
            string option = Console.ReadLine();
            Console.WriteLine();

            return option;
        
        }
        


    }

    
}