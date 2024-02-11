using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Goal goal = new Goal();
        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();

        List<string> options = new List<string>{"1. Create new goal", "2. List goals", "3. Save goals", "4. load goals", "5. Record event", "6. Quit"};
        List<string> goals = new List<string>{"1. Simple Goal", "2. Eternal Goal", "3. Checklist Goal"};

        string number = "0";

        while (number  != "6")
        {
            Console.WriteLine($"You have {goal.GetPoints()} points");
            Console.WriteLine(" ");

            foreach (string a in options) {

            Console.WriteLine(a);
            }

            Console.WriteLine("What do you want to do?");
            number = Console.ReadLine();

            if (number == "1") //Create goal option
            {   

                string answer = "0";

                Console.WriteLine("The types of goal are:");
                foreach (string b in goals) {

                    Console.WriteLine(b);
                }
                Console.WriteLine("Please type a number: ");
                answer = Console.ReadLine();

                if (answer == "1") {
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    simpleGoal.SetShortName(name);
                    Console.WriteLine("What is a short description of it?");
                    string description = Console.ReadLine();
                    simpleGoal.SetDescription(description);
                    Console.WriteLine("What is the amount of points associated with this goal?");;
                    string points = Console.ReadLine();
                    int pointInt = int.Parse(points);
                    simpleGoal.SetPoints(pointInt);

                    using(StreamWriter sw = File.AppendText(goal._fileName))
                    {
                        sw.WriteLine($"[] {simpleGoal.GetShortName()} ({simpleGoal.GetDescription()})");
                    }

                    using(StreamWriter sw = File.AppendText(goal._dataFile))
                    {
                        sw.WriteLine($"Simple,{simpleGoal.GetShortName()},{simpleGoal.GetDescription()},{simpleGoal.GetPoints()}");
                    }

                }

                if (answer == "2"){

                    Console.WriteLine("What is the name of your goal? ");
                    string name2 = Console.ReadLine();
                    eternalGoal.SetShortName(name2);
                    Console.WriteLine("What is a short description of it?");
                    string description2 = Console.ReadLine();
                    eternalGoal.SetDescription(description2);
                    Console.WriteLine("What is the amount of points associated with this goal?");;
                    string points2 = Console.ReadLine();
                    int pointInt2 = int.Parse(points2);
                    eternalGoal.SetPoints(pointInt2);

                    using(StreamWriter sw = File.AppendText(goal._fileName))
                    {
                        
                        sw.WriteLine($"[] {eternalGoal.GetShortName()} ({eternalGoal.GetDescription()})");
                    }
                    
                    using(StreamWriter sw = File.AppendText(goal._dataFile))
                    {
                        sw.WriteLine($"Eternal,{eternalGoal.GetShortName()},{eternalGoal.GetDescription()},{eternalGoal.GetPoints()}");
                    }
                }

                if (answer == "3") {
                    Console.WriteLine("What is the name of your goal? ");
                    string name3 = Console.ReadLine();
                    checklistGoal.SetShortName(name3);
                    Console.WriteLine("What is a short description of it?");
                    string description3 = Console.ReadLine();
                    checklistGoal.SetDescription(description3);
                    Console.WriteLine("What is the amount of points associated with this goal?");;
                    string points3 = Console.ReadLine();
                    int pointInt3 = int.Parse(points3);
                    checklistGoal.SetPoints(pointInt3);
                    Console.WriteLine("How many times does this goal need to be accomplish for a bonus?");
                    string times = Console.ReadLine();
                    int timesInt = int.Parse(times);
                    checklistGoal.SetTarget(timesInt);
                    Console.WriteLine("What is the bonus for accomplish in that many times?");
                    string bonus = Console.ReadLine();
                    int bonusInt = int.Parse(bonus);
                    checklistGoal.SetBonus(bonusInt);
                    

                    using(StreamWriter sw = File.AppendText(goal._fileName))
                    {
                        
                        sw.WriteLine($"[] {checklistGoal.GetShortName()} ({checklistGoal.GetDescription()}) -- Currently completed: {checklistGoal.GetAmountCompleted()}/{checklistGoal.GetTarget()}");
                    }

                    using(StreamWriter sw = File.AppendText(goal._dataFile))
                    {
                        sw.WriteLine($"Checklist,{checklistGoal.GetShortName()},{checklistGoal.GetDescription()},{checklistGoal.GetPoints()},{checklistGoal.GetTarget()},{checklistGoal.GetBonus()}");
                    }
                }
                

                
                
            }

            else if (number == "2") //Display option
            {

                string  copyTxt = File.ReadAllText(goal._fileName);
                Console.Out.WriteLine(copyTxt);

            }

            else if (number == "3") //Save Option
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                string fileData = $"data{filename}";

                string  copyTxt = File.ReadAllText(goal._fileName);
                File.WriteAllText(filename, copyTxt);

                /* Save the data separated by commas to a file */

                string  copyTxt2 = File.ReadAllText(goal._dataFile);
                File.WriteAllText(fileData, copyTxt2);

            }

            else if (number == "4") //Load option
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                string  copyTxt = File.ReadAllText(filename);
                File.WriteAllText(goal._fileName, copyTxt);

                string dataFile = $"data{filename}";
                string copyTxt2 = File.ReadAllText(dataFile);
                File.WriteAllText(goal._dataFile, copyTxt2);
                
            }

            else if (number == "5")
            {
                
                string[] lines = File.ReadAllLines(goal._dataFile);
                
                Console.WriteLine("The goals are: ");
                Console.WriteLine(" ");

                int numIndex = 1;
                foreach (string line in lines){

                    string [] parts = line.Split(",");
 
                    string goalName = parts[2];

                    Console.WriteLine($"{numIndex}. {goalName}");
                    numIndex += 1;
                }
                string ans = Console.ReadLine();
                int ansInt = int.Parse(ans);
                Console.WriteLine(" ");

                string lineSelected = lines[ansInt - 1];

                string [] strings = lineSelected.Split(","); 

                string points = strings[3];
                int pointsInt = int.Parse(points);


                if (lineSelected.Contains("Simple")) {
                    string[] fileContent = File.ReadAllLines(goal._fileName);
                    fileContent[ansInt - 1] = fileContent[ansInt - 1].Replace("[]", "[x]");
                    File.WriteAllLines(goal._fileName, fileContent);
                    
                }


                if (strings[0].Contains("Checklist")) {
                    
                    string bonus = strings[5];
                    int bonusInt = int.Parse(bonus);

                    string amount = strings[4];
                    int amountInt = int.Parse(amount);

                    checklistGoal.SetAmountCompleted(1);

                    int oldAmount = checklistGoal.GetAmountCompleted() - 1;
                    string strOldAmount = oldAmount.ToString();

                    int newAmount = checklistGoal.GetAmountCompleted();
                    string strNewAmount = newAmount.ToString();

                    string[] timesCompleted = File.ReadAllLines(goal._fileName);
                    timesCompleted[ansInt - 1] = timesCompleted[ansInt - 1].Replace(strOldAmount, strNewAmount);
                    File.WriteAllLines(goal._fileName, timesCompleted);

                    if (checklistGoal.GetAmountCompleted() == amountInt) {
                        
                        goal.SetPoints(bonusInt);

                        string[] fileContent = File.ReadAllLines(goal._fileName);
                        fileContent[ansInt - 1] = fileContent[ansInt - 1].Replace("[]", "[x]");
                        File.WriteAllLines(goal._fileName, fileContent);

                        Console.WriteLine($"You have earned a bonus of {bonus} points");
                    }
                }

                Console.WriteLine($"You earned {points} points");
                    
                goal.SetPoints(pointsInt);
                
                
            }

            else if (number == "6")
            {
                File.WriteAllText(goal._fileName, String.Empty);
                File.WriteAllText(goal._dataFile, String.Empty);
            }

        } 

        
    } 
    
}