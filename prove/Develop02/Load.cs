using System.IO.Enumeration;
using Microsoft.VisualBasic;

public class Load
{   
    Write write = new Write();
    public void FileLoaded() {

        Console.WriteLine("What is the file name? ");
        string filename = Console.ReadLine();
        string  copyTxt = File.ReadAllText(filename);
        File.WriteAllText(write._fileName, copyTxt);
    }
}