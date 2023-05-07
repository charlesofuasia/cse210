using System;

class Program
{
    static void Main(string[] args)
    {
    
        PromptGenerator _prompt = new PromptGenerator();
        _prompt._dayLessonPrompt = "What is the most important lesson you learnt today?";

        Console.WriteLine(_prompt._dayLessonPrompt);
    }
}