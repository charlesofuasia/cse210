using System;

public class Manager
{
    public List<Goal> _goals = new List<Goal>();


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
       
       else if(type == "2")
       {
            EternalGoals eternal = new EternalGoals(name, description, points, complete);
            _goals.Add(eternal);
       }
       else if(type == "3")
       {
            Console.Write("How many times would you want this repeated? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus point if goal is achieved? ");
            int bonus = int.Parse(Console.ReadLine());
            int current = 0;

            ChecklistGoals checklist = new ChecklistGoals(target, current, bonus, name, description, points, complete);
            _goals.Add(checklist);
       }
       else
       {
            Console.WriteLine("Please select between nos 1- 3");
       }

    }

    public void DisplayGoals()
    {
        foreach(Goal goal in _goals)
        {
            if(goal.GoalIsComplete())
            {
                Console.Write("[ X ] : ");
            }
            else
            {
                Console.Write("[  ] : ");
            }
            Console.WriteLine(goal.FormatDisplay());
        }
    }


}