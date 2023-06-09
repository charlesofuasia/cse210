using System;

public class ListingActivity: Activity
{
    private string _listPrompt;
    private List<string> _prompts;
    private List<string> _itemsList;

    public ListingActivity()
    {
        _activityName = "Listing";
        _activityDescription = "Listing activity will help you think of subject matters and list out as many things as you can relate with that subject";
        _activityInstruction = "You will be presented with a random subject and at the prompt, list as many things as you can relating to the subject";
      
    }
    private string GetListPrompt()
    {
         _prompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random rnd = new Random();
        int i = rnd.Next(_prompts.Count);
        _listPrompt = _prompts[i];
        return _listPrompt;
    }

    public void RunListingActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.WriteLine();
        ActivatePause(5);
        Console.WriteLine(_activityInstruction);
        Thread.Sleep(1000);
        ActivatePause(7);
        Console.WriteLine();
        _activityDuration = GetDuration();
        
        ActivatePause(5);
        PrepareToStart();
        
        _itemsList = new List<string>();
        
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_activityDuration);
        Console.Clear();
        Console.WriteLine(GetListPrompt());

        while(DateTime.Now < end)
        {
            Console.CursorVisible = true;
            string ans = Console.ReadLine();
            _itemsList.Add(ans);
        }
        Console.WriteLine();
        Console.WriteLine("Done");
        ActivatePause(3);
        Console.WriteLine($"You listed {_itemsList.Count} {InsertNoun(_itemsList.Count)} after {_activityDuration} seconds of {_activityName} Activity.");
        ActivatePause(5);
        DisplayEndMessage();

        static string InsertNoun(int count){
            if(count <= 1)
            {
                return "item";
            }
            else
            {
                return "items";
            }
        }
    }
}