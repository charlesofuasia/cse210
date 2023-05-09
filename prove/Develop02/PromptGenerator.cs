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

    public string GenerateRandomPrompt()// A method that returns a random prompt from PromptGenerator attributes.
    {
        // A list variable is created to which all the the prompt generator 
        // attributes are added to serially
        List<string> prompters = new List<string>();
        prompters.Add(_dayLessonPrompt);
        prompters.Add(_dayTasksPrompt);
        prompters.Add(_improvementPrompt);
        prompters.Add(_remarkableEventPrompt);
        prompters.Add(_remarkablePersonprompt);
        prompters.Add(_scripturePrompt);

        var random = new Random(); //new variable declared to generate a random integer from range of
        int index = random.Next(prompters.Count);// the length of prompters list

    
       string randomPrompt = prompters[index];// the random prompt is at the index of the randomly generated integer
       return randomPrompt; // The PromptGenerator returns the randomly selected prompt.

    }
}
