using System;

public class Word
{
    //Attributes for the Word Class
    private string _visibleWord;
    private bool _isHidden;

    //Word class constructor
    public Word(string word)
    {
        _visibleWord = word;
        _isHidden = false;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public void DisplayWord()
    {
        if (_isHidden)
        {
            foreach(char letter in _visibleWord)
            {
                Console.Write("_");
            }
        }
        else
            {
                Console.Write(_visibleWord);
            }
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

}



