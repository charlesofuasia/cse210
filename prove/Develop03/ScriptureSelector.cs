using System;
using System.IO;

public class ScriptureSelector
{
    private string _verseText;
    private string _referenceString;
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;
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
        string workingRef = _referenceString.Replace(" ", ":");
        string [] newReference = workingRef.Split(":");
        _book = newReference[0];
        _chapter = newReference[1];
        _startVerse = newReference[2];
        _endVerse = null;

        
    }

    public string GetText()
    {
        return _verseText;
    }
    public string GetBook()
    {
        return _book;
    }
    public string GetChapter()
    {
        return _chapter;
    }
    public string GetVerse()
    {
        return _startVerse;
    }

}