using System;
using System.IO;

public class ScriptureSelector
{
    private string _verseText;
    private string _referenceString;
    private string _filename;

    public ScriptureSelector(string filename)
    {
        string [] lines = System.IO.File.ReadAllLines(filename);
        Random random = new Random();
        int i = random.Next(0, lines.Count());
        string line = lines[i];
        string cleanLine = line.Trim();
        string [] arrLine = cleanLine.Split("~~");
        _referenceString = arrLine[0];
        _verseText = arrLine[1];
        _filename = filename;
    }

    public string GetText()
    {
        return _verseText;
    }

}