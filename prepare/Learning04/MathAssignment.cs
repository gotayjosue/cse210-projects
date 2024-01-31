using System.Text.RegularExpressions;

public class MathAssignment : Assignment 
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment (string studentName, string topic, string textbookSection, string poblems) : base (studentName, topic)
    {

        _textbookSection = textbookSection;
        _problems = poblems;
    
    }

    public string GetHomeworkList() {
        return $"{_textbookSection} {_problems}";
    }
}