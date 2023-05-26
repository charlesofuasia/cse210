using System;

public class Scripture
{
    private List<Word> _words;//a list of Word types got from splitting the verse into individual words
    private Reference _reference; //from the reference class

    //Scripture constructors
    //the constructor accepts 2 parameters, a reference and a string variable
    //and stores the verse to be memorized
    public Scripture(Reference reference, string text){
        _words = new List<Word>(); //_words array is instantiated
        string[] words = text.Split(" ");//and verse split at spaces between words
        foreach (string word in words)
        {
            Word x = new Word(word); // Instance of word with the encapsulated _visibleWord assessed 
            _words.Add(x);          // through the constructor Word(word)
                        //word in words assigned into x which is an instance of Word class and added to _words
        }  
        _reference = reference;
    }

    //A getter to be used to access the encapsulated _words
    public List<Word> GetWords()
    {
        return _words;
    }

    public void DisplayScripture()
    {
        _reference.GetReference();
        foreach(Word item in _words)
        {
            item.DisplayWord();
            Console.Write(" ");
        }
       
    }

    public bool AllHidden()
    {
        foreach(Word item in _words)
        {
            if(!item.GetIsHidden())
                return false;
        }
        return true;
    }
}