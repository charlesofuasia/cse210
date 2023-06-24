using System;

class Program
{
    //For creativity, I added an animation effect that is activated if a goal is completed.
    //Added a try/catch to prevent blow up if user enters non existing file in LoadGoal method.
    // An appropraite message is displayed if the user selects list option if the goal list is empty
    //Also an appropraite message is displayed if the user chooses save while the goal list is empty.
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Eternal Goal Quest Program.");
        Manager manager = new Manager();

        string option = ChooseOptions();

        if (option != "6")
        {
            while (option != "6")
            {
                switch (option)
                {
                    case "1":
                        manager.CreateGoal();
                        option = ChooseOptions();
                        break;

                    case "2":
                        manager.ListGoals();
                        option = ChooseOptions();
                        break;

                    case "3":
                        manager.SaveGoals();
                        option = ChooseOptions();
                        break;

                    case "4":
                        manager.RecordEvent();
                        option = ChooseOptions();
                        break;

                    case "5":
                        manager.LoadGoals();
                        option = ChooseOptions();
                        break;

                    case "6":
                        break;

                    default:
                        Console.WriteLine("Wrong entry. Try again");
                        option = ChooseOptions();
                        break;
                }

            }

        }


        Console.WriteLine("You have exited the program. Thank you.");
    }



    static string ChooseOptions()
    {
        /*A function that displays options and prompts user to choose one option
           Parameters: none
           Returns : string option.
        */
        Console.WriteLine("\nList of Options.");
        Console.WriteLine("1. Create A Goal.\n2. List Goals.\n3. Save Goals.\n4. Record Event\n5. Load Goals.\n6. Exit");
        Console.Write("Choose any of 1 - 6: ");
        string option = Console.ReadLine();
        return option;
    }
}
