using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment1 = new Assignment("Josue Gotay -", "Science");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine("");

        MathAssignment mathAssignment = new MathAssignment("Samuel Bennet -", "Multiplication", "Section 7.3", "Problems 8 - 19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters -", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        
        
        
    }
}