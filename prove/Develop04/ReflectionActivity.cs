using System;

public class ReflectionActivity: Activity
{
    private string _prompt;
    private string _question;
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _usedQuestions;

    public ReflectionActivity(){
        _activityName = "Reflection";
        _activityDescription = "The Reflection activity helps you to reflect on various aspects of your life";
        _activityEndMessage = "Congratulations! You have completed the reflection activity.";
        _activityInstruction = "You are choose the length of time you wish to spend reflecting, then the program will present you a random subject to reflect on, after which random questions will be presented to you to help deepen your thoughts on the selected topic";
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
       
        _questions = new List<string>(){
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? "
        };
        Random rnd = new Random();
        int j = rnd.Next(_questions.Count);
        _question = _questions[j];
        return _question;
    }


    public void RunReflectionActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.WriteLine();
        ActivatePause(5);
        Console.WriteLine(_activityInstruction);
       
        ActivatePause(15);
        _activityDuration = GetDuration();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_activityDuration);
        Console.WriteLine(GetPrompt());
        Console.WriteLine();
        Console.Write("Press 'ENTER' when you are ready to start: ");
        string begin = Console.ReadLine();
        if(begin == "")
        {
            _usedQuestions = new List<string>();
            Console.Write("Begin in... ");
            ActivateActivityTimer(4);
            Console.WriteLine(" seconds");
            while(DateTime.Now < end)
            {
                string question = GetQuestion(); 
                Console.Write(question);
                _usedQuestions.Add(question);
                ActivatePause(10);
                Console.WriteLine();
                
            }       
        }
    }
}