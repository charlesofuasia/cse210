using System;

public class PromptGenerator
{
    // The following are the attributes for the PromptGenerator class
    public string _scripturePrompt;
    public string _improvementPrompt;
    public string _remarkableEventPrompt;
    public string _remarkablePersonprompt;
    public string _dayTasksPrompt;
    public string _dayLessonPrompt;

    public void GenerateRandomPrompt()
    {
        List<string> prompters = new List<string>();
        prompters.Add(_dayLessonPrompt);
        prompters.Add(_dayTasksPrompt);
        prompters.Add(_improvementPrompt);
        prompters.Add(_remarkableEventPrompt);
        prompters.Add(_remarkablePersonprompt);
        prompters.Add(_scripturePrompt);

        foreach(string promter in prompters)
        {
            Console.WriteLine(promter);
        }

    }
}
