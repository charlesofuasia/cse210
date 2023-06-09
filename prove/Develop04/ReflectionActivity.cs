using System;

public class ReflectionActivity: Activity
{
    private string _prompt;

    private List<string> _prompts;
    
    private List<string> _questions;
    private List<int> _usedIndexes;

    public ReflectionActivity(){
        _activityName = "Reflection";
        _activityDescription = "The Reflection activity helps you to reflect on various aspects of your life";
        _activityInstruction = "You are to choose the length of time you wish to spend reflecting, then the program will present you a random subject to reflect on, after which random questions will be presented to you to help deepen your thoughts on the selected topic";
    }
    private string GetPrompt()
    {
            _prompts = new List<string>(){
            "Think about a time you truly felt joy in your heart",
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless."

        };
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        _prompt = _prompts[i];
        
        return _prompt;
    }
    private string GetQuestion()
    {
        int j;
        Random rnd = new Random();
        do
        {
            j = rnd.Next(_questions.Count);
        }
        while(_usedIndexes.Contains(j));
        _usedIndexes.Add(j);
        return _questions[j];
    }


    public void RunReflectionActivity()
    {
        _questions = new List<string>(){
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _usedIndexes = new List<int>();
        Console.Clear();
        DisplayStartMessage();
        ActivatePause(5);
        Console.WriteLine();
        ActivatePause(10);
        _activityDuration = GetDuration();
        ActivatePause(5);
        Console.WriteLine();
      
        Console.WriteLine(GetPrompt());
        ActivatePause(5);
        Console.WriteLine();
        Console.Write("Press 'ENTER' when you are ready to start: ");
        string begin = Console.ReadLine();
        if(begin == "")
        {
        
            PrepareToStart();
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(_activityDuration);
            while(DateTime.Now < end)
            {
                string question = GetQuestion(); 
                Console.Write(question);

                ActivatePause(10);
                Console.WriteLine();    
            } 
            Console.WriteLine("Done.");
            Thread.Sleep(1500);
            DisplayEndMessage();      
        }
        
    }
}