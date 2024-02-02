using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
    

        List<string> options = new List<string>{"1. Start breathing activity","2. Start reflecting activity","3. Start listing activity","4. Quit"};

        List<string> breath = new List<string>{};
        breath.Add("Breathe in");
        breath.Add("Now breathe out");

        string answer = "0";

        while (answer != "4") {

            foreach (string a in options) {
                Console.WriteLine(a);
            }
            answer = Console.ReadLine();

            if (answer == "1")
            { 
                BreathingActivity breathingActivity = new BreathingActivity("Welcome to the Breathing Activity.","Well done!");
                Console.WriteLine(breathingActivity.GetStartingMessage());
                Console.WriteLine("");
                BreathingActivity breathingActivity1 = new BreathingActivity("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.","");
                Console.WriteLine(breathingActivity1.GetStartingMessage());
                Console.WriteLine(" ");


                Console.WriteLine("How much time (in seconds) do you want to spend in this activity?");
                string input = Console.ReadLine();
                int time = int.Parse(input);
                BreathingActivity breathingActivity2 = new BreathingActivity(time);
                Console.WriteLine(" ");

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(breathingActivity2.GetDuration());

                Console.WriteLine("Get ready");
                breathingActivity.Dots(4);
                Console.WriteLine(" ");
                Console.WriteLine(" ");


                while (DateTime.Now < endTime) {
                    
                    Console.Write($"{breath[0]}");
                    breathingActivity.Dots(4);
                    Console.WriteLine(" ");
                    Console.Write($"{breath[1]}");
                    breathingActivity.Dots(4);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    {
                        
                    }     
                }
                Console.WriteLine(" ");

                Console.WriteLine(breathingActivity.GetEndingMessage());
                Console.WriteLine(" ");
                Console.WriteLine($"You have complete another {time} seconds of the Breathing Activity");
                Console.WriteLine(" ");

            }

            if (answer == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Welcome to the Reflection Activity","Well done!");
                Console.WriteLine(reflectionActivity.GetStartingMessage());
                Console.WriteLine(" ");
                ReflectionActivity reflectionActivity1 = new ReflectionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.","");
                Console.WriteLine(reflectionActivity1.GetStartingMessage());
                Console.WriteLine(" ");
                Console.WriteLine("How much time (in seconds) do you want to spend in this activity?");
                string input = Console.ReadLine();
                int time2 = int.Parse(input);
                ReflectionActivity reflectionActivity2 = new ReflectionActivity (time2);
                Console.WriteLine(" ");

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(reflectionActivity2.GetDuration());

                Console.WriteLine("Get ready");
                reflectionActivity.Dots(4);
                Console.WriteLine(" ");
                Console.WriteLine(" ");


                Console.WriteLine("Consider the following prompt");
                Console.WriteLine(" ");
                var reflectionPrompt = reflectionActivity.reflections;
                var random = new Random();
                int index = random.Next(reflectionPrompt.Count);
                Console.WriteLine(reflectionPrompt[index]);

                Console.WriteLine(" ");
                Console.WriteLine("Press enter when you have an idea");
                Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
                Console.WriteLine("You may begin in: ");
                reflectionActivity.Dots(4);
                Console.WriteLine(" ");

                

                while (DateTime.Now < endTime) {
                    var reflectionQuestions = reflectionActivity.reflectQuestions;
                    var random2 = new Random();
                    int index2 = random2.Next(reflectionQuestions.Count);
                    
                    Console.Write($"-- {reflectionQuestions[index2]}");
                    reflectionActivity.Dots(5);
                    Console.WriteLine(" ");
            
                }
                Console.WriteLine("");
                reflectionActivity.GetEndingMessage();
                Console.WriteLine("");
                Console.WriteLine($"You have complete another {time2} seconds of the Reflection Activity");
                Console.WriteLine(" ");


            }

            if (answer == "3") {

                ListingActivity listingActivity = new ListingActivity("Welcome to the Listing Activity","Well done!");
                Console.WriteLine(listingActivity.GetStartingMessage());
                Console.WriteLine(" ");

                ListingActivity listingActivity1 = new ListingActivity("This activity will help you reflect on the good things in your life by having you list as many things \nas you can in a certain area.","");
                Console.WriteLine(listingActivity1.GetStartingMessage());
                Console.WriteLine(" ");

                Console.WriteLine("How much time (in seconds) do you want to spend in this activity?");
                string input = Console.ReadLine();
                int time3 = int.Parse(input);
                ListingActivity listingActivity2 = new ListingActivity(time3);
                Console.WriteLine(" ");

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(listingActivity2.GetDuration());

                Console.WriteLine("Get ready");
                listingActivity.Dots(4);
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("Write as many answers you can to the following prompt:");
                var listing = listingActivity.listingQuestions;
                var random2 = new Random();
                int index2 = random2.Next(listing.Count);
                Console.WriteLine($"-- {listing[index2]}");
                Console.WriteLine("You may begin in: ");
                // Console.WriteLine(" ");
                // Thread.Sleep(3000);
                listingActivity.Dots(8);
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                List<string> prompts = new List<string>{};

                while (DateTime.Now < endTime) {

                    Console.Write("> ");
                    string prompt = Console.ReadLine();
                    prompts.Add(prompt);
                }
                Console.WriteLine($"You listed {prompts.Count} items");
                Console.WriteLine(" ");
                Console.WriteLine(listingActivity.GetEndingMessage());
                Console.WriteLine("");
                Console.WriteLine($"You have complete another {time3} seconds of the Listing Activity");
                Console.WriteLine(" ");



            }
        }

        

    }
}