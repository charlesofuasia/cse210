using System;

public class Reference
{
    //Reference class attttributes
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    //The constructors
    public Reference(string book, string chapter, string verse)// for only 1 scripture verse
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    //the sole task of the Reference class is to display the reference of the text being memorized
    //the only method serves a display function
    public void GetReference()
    {
        if (_endVerse == null)
        {
             Console.WriteLine($"\n{_book} {_chapter}: {_startVerse}");
        }
           
        else
        {
            Console.WriteLine($"\n{_book} {_chapter}: {_startVerse} - {_endVerse}");
        }
    
            
    }
   
}