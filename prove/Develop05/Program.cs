using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Clear();
        Manager manager = new Manager();

        manager.CreateGoal("1");
        Console.Clear();
        manager.CreateGoal("2");
        Console.Clear();
        manager.CreateGoal("3");
        manager.DisplayGoals();

    }
}