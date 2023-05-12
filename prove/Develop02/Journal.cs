using System;

using System.IO;


public class Journal
{
    public string _filename;

    public List<Entry> _entries = new List<Entry>();



    public void SaveToFile(string filename, List<Entry> entry )
    {
        using(StreamWriter output = new StreamWriter(_filename) )
            {
                foreach(Entry i in _entries)
                {
                    output.Write($"{i._date}: ");
                    output.WriteLine(i._entryPrompt);
                    output.WriteLine(i._entry);
                }
            }

        
        

    }


    public void DisplayJournal()
    {
        foreach(Entry entry in _entries)
        {
            entry.CreateNewEntry();
        }
    }

    public void LoadFromFile(string filename)
    {
        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }
    
    
}
