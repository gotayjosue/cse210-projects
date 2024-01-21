using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.IO;
public class Write 
{   

    public string _fileName = "main.txt";

    public void DisplayQuestions() {
        List<string> questions = new List<string>{"How was your day?", "What did you do today?", "What was your best moment today?", "How much did you feel the Savior's Love this day?",
        "What is one thing you could have done differently today?"};
        var random = new Random();
        int index = random.Next(questions.Count);
        Console.WriteLine(questions[index]);
   
     }
    
}