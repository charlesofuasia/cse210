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
                    output.Write($"{i._date}: ");
                    output.WriteLine(i._entryPrompt);
                    output.WriteLine();
                    output.WriteLine($"\t   {i._entry}");
                    output.WriteLine();
                    output.WriteLine();
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

        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }
    
    
}
