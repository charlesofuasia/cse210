using System;

using System.IO;

public class Journal
{
    public string _filename;

    public List<Entry> _entries = new List<Entry>();


    public void SaveToFile(string filename, List<Entry> entry )
    {
        using(StreamWriter output = new StreamWriter(_filename))
        {
            output.WriteLine(entry);
        }
        

    }

    public void LoadFromFile()
    {
        //code here


    }

    public void DisplayJournal()
    {
        foreach(Entry entry in _entries)
        {
            entry.CreateNewEntry();
        }
    }
    
    
}
