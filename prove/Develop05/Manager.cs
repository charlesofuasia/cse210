using System;

public class Manager
{
    public List<Goal> _goals;

    public void CreateGoal(string type)
    {
        Console.Write("What is the name of the goal?: ");
        string name = Console.ReadLine();
        Console.Write("Give a brief description of goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points is this goal? ");
        int points = int.Parse(Console.ReadLine());
        bool complete = false;
        if(type == "1")
        {
            SimpleGoal simple = new SimpleGoal(name, description, points, complete);
            _goals.Add(simple);
        }
       

    }


    
}