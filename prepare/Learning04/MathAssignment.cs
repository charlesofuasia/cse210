using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _mathQuestions;

    public MathAssignment(string name, string topic, string textbook, string questions) : base(name, topic)
    {
        _textbookSection = textbook;
        _mathQuestions = questions;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_mathQuestions}";
    }
}