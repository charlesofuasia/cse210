using System;

public class Entry
{
    public string _date;//Entry attribute for date
    public string _entryPrompt;//the _prompt attribute to hold a random prompt from PromptGenerator class
    public string _entry; // _newEntry holds the entry inputed by the user

    public string _entryTime;



//CreateNewentry method puts together the _date, _prompt and _newEntry into an easily readable format.
    public void CreateNewEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"{_date} @ {_entryTime} {_entryPrompt}");
        Console.WriteLine();
        Console.WriteLine($"\t  {_entry}");
        Console.WriteLine();

    }
}