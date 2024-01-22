using System;
using System.Globalization;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
        Write write = new Write();
        Save save = new Save();
        Load load = new Load();
        
        List<string> options = new List<string>{"1. Write", "2. Display", "3. Load", "4. Save", "5. Clear a journal file", "6. Quit"};

        string number = "0";

        while (number  != "6")
        {

            foreach (string a in options) {

            Console.WriteLine(a);
            }

            Console.WriteLine("What do you want to do?");
            number = Console.ReadLine();

            if (number == "1") //Write option
            {   
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                write.DisplayQuestions();
                
                using(StreamWriter sw = File.AppendText(write._fileName))
                {
                    Console.WriteLine("Prompt: ");
                    string text = Console.ReadLine();
                    sw.WriteLine();
                    sw.WriteLine($"{dateText} {text}");
                }
            }

            else if (number == "2") //Display option
            {

                string  copyTxt = File.ReadAllText(write._fileName);
                Console.Out.WriteLine(copyTxt);

            }

            else if (number == "3") //Load option
            {
                load.FileLoaded();

            }

            else if (number == "4") //Save option
            {
                save.SaveFile();
            }

            else if (number == "5") //Clear a journal file option. It allows the user to clear all the text of the journal files he created before. Then, when the user loads the files
                                    // they do not have any text. The user can erase the content of loaded files too, but the changes are going to take effect after the user close
                                    // the program.
            {
                Console.WriteLine("Please type the file name: ");
                string filename = Console.ReadLine();
                File.WriteAllText(filename, String.Empty);
                
            }

            else if (number == "6")
            {
                File.WriteAllText(write._fileName, String.Empty);
            }

        }   

        
        
    }
        
        

    
}