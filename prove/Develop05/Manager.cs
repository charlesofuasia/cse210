using System;
using System.IO;

public class Manager
{
    public List<Goal> _goals = new List<Goal>();
    public int _totalPoints = 0;


    public void CreateGoal()
    {
        Console.WriteLine("\nThe Goal types are:");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Choose any of 1 - 3: ");
        string type = Console.ReadLine();

        if (type == "1")
        {
            Console.Write("What is the name of the goal?: ");
            string name = Console.ReadLine();
            Console.Write("Give a brief description of goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal? ");
            int points = int.Parse(Console.ReadLine());
            bool complete = false;
            SimpleGoal simple = new SimpleGoal(name, description, points, complete);
            _goals.Add(simple);
        }

        else if (type == "2")
        {
            Console.Write("What is the name of the goal?: ");
            string name = Console.ReadLine();
            Console.Write("Give a brief description of goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal? ");
            int points = int.Parse(Console.ReadLine());
            bool complete = false;
            EternalGoals eternal = new EternalGoals(name, description, points, complete);
            _goals.Add(eternal);
        }
        else if (type == "3")
        {
            Console.Write("What is the name of the goal?: ");
            string name = Console.ReadLine();
            Console.Write("Give a brief description of goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal? ");
            int points = int.Parse(Console.ReadLine());
            bool complete = false;
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

    public void ListGoals()
    {
        Console.Clear();
        Console.WriteLine($"\tTotal Points : {_totalPoints}");
        if (_goals.Count < 1)
        {
            Console.WriteLine("You have not included any goals yet in your list");
        }
        else
        {
            foreach (Goal goal in _goals)
            {
                if (goal.GoalIsComplete())
                {
                    Console.Write("[ X ] : ");
                }
                else
                {
                    Console.Write("[   ] : ");
                }
                Console.WriteLine(goal.FormatDisplay());
            }
        }
    }

    public void SaveGoals()
    {
        if (_goals.Count < 1)
        {
            Console.WriteLine("There are no goals to save. Create a goals list before saving");
        }
        else
        {
            Console.Write("Choose a filename to save to: ");
            string filename = Console.ReadLine();

            using (StreamWriter output = new StreamWriter(filename))
            {
                output.WriteLine(_totalPoints);
                foreach (Goal goal in _goals)
                {
                    output.WriteLine(goal.FormatSave());
                }
            }
            Console.WriteLine($"\nYour goals have been saved to {filename}.");
        }
    }

    public void LoadGoals()
    {
        try
        {
            _goals.Clear();
            Console.Write("What is the filename you wish to load from? ");
            string filename = Console.ReadLine();
            Console.WriteLine();

            string[] lines = System.IO.File.ReadAllLines(filename);
            for (int i = 0; i < lines.Count<string>(); i++)
            {
                if (i == 0)
                {
                    _totalPoints = int.Parse(lines[i]);
                }
                else
                {
                    string[] goal = lines[i].Split("|");
                    switch (goal[0])
                    {
                        case "Simple Goal":
                            SimpleGoal simple = new SimpleGoal(goal[1], goal[2], int.Parse(goal[3]), bool.Parse(goal[4]));
                            _goals.Add(simple);
                            break;

                        case "Eternal Goal":
                            EternalGoals eternal = new EternalGoals(goal[1], goal[2], int.Parse(goal[3]), bool.Parse(goal[4]));
                            _goals.Add(eternal);
                            break;

                        case "Checklist Goal":
                            ChecklistGoals checklist = new ChecklistGoals(int.Parse(goal[5]), int.Parse(goal[6]), int.Parse(goal[7]), goal[1], goal[2], int.Parse(goal[3]), bool.Parse(goal[4]));
                            _goals.Add(checklist);
                            break;
                    }
                }
            }
            ListGoals();
        }
        catch
        {
            Console.WriteLine("File cannot be found.");
        }
    }


    public void RecordEvent()
    {
        Console.Clear();
        List<Goal> pendingGoals = new List<Goal>();
        Console.WriteLine("Goals to record:\n");
        int counter = 1;
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i].GoalIsComplete() == false)
            {
                pendingGoals.Add(_goals[i]);
                Console.WriteLine($"{counter}. {_goals[i].GetGoalName()}");
                counter++;
            }
        }
        if (pendingGoals.Count < 1)
        {
            Console.WriteLine("You have no pending goals to record. You may need to create a new list.");
        }
        else
        {
            try
            {

                Console.Write($"\nWhich goal nos would you like to record? Choose any of 1 - {counter - 1}: ");
                int option = int.Parse(Console.ReadLine());
                _totalPoints += pendingGoals[option - 1].RecordEvent();
            }
            catch
            {
                Console.WriteLine($"\nYou have made an invalid entry. To Record event choose only from 1 -{counter - 1}. ");
            }
        }

    }

}