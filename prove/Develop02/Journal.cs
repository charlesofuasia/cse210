using System;
using System.IO;

public class Journal
{
    public string _filename;

    public List<Entry> _entries = new List<Entry>();

    public void SaveToFile(string filename, List<Entry> entry )
    {
        /*
            A method that saves a list of entries into a file
            Parameters (2): string filename, List<Entry> _entries

        */
        using(StreamWriter output = new StreamWriter(_filename) )
            {
                foreach(Entry i in _entries)
                {
                    output.WriteLine($"{i._date}#{i._entryTime}#{i._entryPrompt}#{i._entry}"); 
                }
            }
    }

    public void DisplayJournal()
    {/*
        A method that displays entries in the _entries list
        on the console.
        Parameters: None
        Returns: Nothing
    */
        foreach(Entry i in _entries)
        {
           i.CreateNewEntry();           
        }
    }

    public void LoadFromFile(string filename)
    {
        // A method that loads and displays entries that have been saved to a file.
        _entries.Clear();

        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string [] cleanLine = line.Split("#");
            string date = cleanLine[0];
            string time = cleanLine[1];
            string prompt = cleanLine[2];
            string entry = cleanLine[3];

            Console.WriteLine($"{date} @ {time}:- {prompt}");
            Console.WriteLine();
            Console.WriteLine($"\t {entry}");
            Console.WriteLine();
        }
    }  
}
