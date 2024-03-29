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
            /* Write the current score to the score file */
            File.WriteAllText(goal.GetScoreFile(), String.Empty);

            using(StreamWriter sw = File.AppendText(goal.GetScoreFile()))
            {
                sw.WriteLine($"{goal.GetPoints()}");
            }

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

                    simpleGoal.DisplayInfo();

                    using(StreamWriter sw = File.AppendText(goal.GetFileName()))
                    {
                        sw.WriteLine($"[] {simpleGoal.GetShortName()} ({simpleGoal.GetDescription()})");
                    }

                    using(StreamWriter sw = File.AppendText(goal.GetDataFile()))
                    {
                        sw.WriteLine($"Simple,{simpleGoal.GetShortName()},{simpleGoal.GetDescription()},{simpleGoal.GetPoints()}");
                    }

                }

                if (answer == "2"){

                    eternalGoal.DisplayInfo();

                    using(StreamWriter sw = File.AppendText(goal.GetFileName()))
                    {
                        
                        sw.WriteLine($"[] {eternalGoal.GetShortName()} ({eternalGoal.GetDescription()})");
                    }
                    
                    using(StreamWriter sw = File.AppendText(goal.GetDataFile()))
                    {
                        sw.WriteLine($"Eternal,{eternalGoal.GetShortName()},{eternalGoal.GetDescription()},{eternalGoal.GetPoints()}");
                    }
                }

                if (answer == "3") {

                    checklistGoal.DisplayInfo();
                    

                    using(StreamWriter sw = File.AppendText(goal.GetFileName()))
                    {
                        
                        sw.WriteLine($"[] {checklistGoal.GetShortName()} ({checklistGoal.GetDescription()}) -- Currently completed: {checklistGoal.GetAmountCompleted()}/{checklistGoal.GetTarget()}");
                    }

                    using(StreamWriter sw = File.AppendText(goal.GetDataFile()))
                    {
                        sw.WriteLine($"Checklist,{checklistGoal.GetShortName()},{checklistGoal.GetDescription()},{checklistGoal.GetPoints()},{checklistGoal.GetTarget()},{checklistGoal.GetBonus()}");
                    }

                }  
                
            }

            else if (number == "2") //Display option
            {

                string  copyTxt = File.ReadAllText(goal.GetFileName());
                Console.Out.WriteLine(copyTxt);

            }

            else if (number == "3") //Save Option
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                string fileData = $"data{filename}";
                string scoreFile = $"score{filename}";

                /* Save the data that user is going to see */

                string  copyTxt = File.ReadAllText(goal.GetFileName());
                File.WriteAllText(filename, copyTxt);

                /* Save the data separated by commas to a file */

                string  copyTxt2 = File.ReadAllText(goal.GetDataFile());
                File.WriteAllText(fileData, copyTxt2);

                /* Save the user's score */
                string scoreTxt = File.ReadAllText(goal.GetScoreFile());
                File.WriteAllText(scoreFile, scoreTxt);

            }

            else if (number == "4") //Load option
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                string  copyTxt = File.ReadAllText(filename);
                File.WriteAllText(goal.GetFileName(), copyTxt);

                string dataFile = $"data{filename}";
                string copyTxt2 = File.ReadAllText(dataFile);
                File.WriteAllText(goal.GetDataFile(), copyTxt2);

                string scoreFile = $"score{filename}";
                string copyTxt3 = File.ReadAllText(scoreFile);
                File.WriteAllText(goal.GetScoreFile(), copyTxt3);

                /*Load the score to the user */
                
                string [] lines = File.ReadAllLines(goal.GetScoreFile());
                string savedPoints = lines[0];
                int savedPointsInt = int.Parse(savedPoints);
                goal.SetPoints(savedPointsInt);
                
            }

            else if (number == "5")
            {
                /* Iterate through the data file to show the goal description */

                string[] lines = File.ReadAllLines(goal.GetDataFile());
                
                Console.WriteLine("The goals are: ");
                Console.WriteLine(" ");

                int numIndex = 1;
                foreach (string line in lines){

                    string [] parts = line.Split(",");
 
                    string goalName = parts[2];

                    Console.WriteLine($"{numIndex}. {goalName}");
                    numIndex += 1;
                }
                /*Selecting the line of the file where the goal is*/
                string ans = Console.ReadLine();
                int ansInt = int.Parse(ans);
                Console.WriteLine(" ");

                string lineSelected = lines[ansInt - 1];

                /*Split the selected line by commas to find the points index */

                string [] strings = lineSelected.Split(","); 

                string points = strings[3];
                int pointsInt = int.Parse(points);

                /* Evaluating the goal type to mark it as completed */

                if (lineSelected.Contains("Simple")) {
                    string[] fileContent = File.ReadAllLines(goal.GetFileName());
                    fileContent[ansInt - 1] = fileContent[ansInt - 1].Replace("[]", "[x]");
                    File.WriteAllLines(goal.GetFileName(), fileContent);
                    
                }


                if (strings[0].Contains("Checklist")) {
                    
                    string bonus = strings[5];
                    int bonusInt = int.Parse(bonus);

                    string amount = strings[4];
                    int amountInt = int.Parse(amount);

                    int currentCompleted = checklistGoal.GetAmountCompleted();
                    checklistGoal.SetAmountCompleted(currentCompleted + 1);

                    string[] timesCompleted = File.ReadAllLines(goal.GetFileName());
                    timesCompleted[ansInt - 1] = timesCompleted[ansInt - 1].Replace($" {currentCompleted}/", $" {checklistGoal.GetAmountCompleted()}/");
                    File.WriteAllLines(goal.GetFileName(), timesCompleted);

                    if (checklistGoal.GetAmountCompleted() == amountInt) {
                        
                        goal.SetPoints(bonusInt);

                        string[] fileContent = File.ReadAllLines(goal.GetFileName());
                        fileContent[ansInt - 1] = fileContent[ansInt - 1].Replace("[]", "[x]");
                        File.WriteAllLines(goal.GetFileName(), fileContent);

                        Console.WriteLine($"You have earned a bonus of {bonus} points");
                    }
                }

                Console.WriteLine($"You earned {points} points");
                    
                goal.SetPoints(pointsInt);
                
                
            }

            else if (number == "6")
            {
                File.WriteAllText(goal.GetFileName(), String.Empty);
                File.WriteAllText(goal.GetDataFile(), String.Empty);
            }

        } 

        
    } 
    
}