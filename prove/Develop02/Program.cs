using System;

class Program
{
    static void Main(string[] args)
    {
    
        PromptGenerator _prompt = new PromptGenerator();
        _prompt._dayLessonPrompt = "What is the most important lesson you learnt today?";
        _prompt._dayTasksPrompt = "Which important tasks did you carry out today?";
        _prompt._improvementPrompt = "What did you do today that perhaps you can improve upon?";
        _prompt._remarkableEventPrompt = "What do you consider the most remarkable event of today?";
        _prompt._remarkablePersonprompt = "Was there a remarkable person you met today?";
        _prompt._scripturePrompt = "What did you learn from the scriptures study today?";

        _prompt.GenerateRandomPrompt();
    }
}