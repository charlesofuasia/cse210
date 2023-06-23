using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Eternal Goal Quest Program.");
        Manager manager = new Manager();

        string option = ChooseOptions();

        while(option != "6")
        {
            switch(option){
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

            }
           
        }
       
       static string ChooseOptions()
       {
        //Console.Clear();
        Console.WriteLine("\nList of Options.");
        Console.WriteLine("1. Create A Goal.\n2. List Goals.\n3. Save Goals.\n4. Record Event\n5. Load Goals.\n6. Exit");
        Console.Write("\nChoose any of 1 - 6: ");
        string option = Console.ReadLine();
        return option;
       }
    }
}