using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Main class
class Program
{
    static void Main(string[] args)
    {
        // Create goals
        Goal marathonGoal = new SimpleGoal("Run a marathon", 1000);
        Goal readScripturesGoal = new EternalGoal("Read scriptures", 100);
        Goal templeGoal = new ChecklistGoal("Attend the temple", 50, 10);

        // Create goal tracker
        GoalTracker tracker = new GoalTracker();
        tracker.AddGoal(marathonGoal);
        tracker.AddGoal(readScripturesGoal);
        tracker.AddGoal(templeGoal);

        // Record events
        tracker.RecordEvent("Run a marathon");
        tracker.RecordEvent("Read scriptures");
        tracker.RecordEvent("Attend the temple");
        tracker.RecordEvent("Attend the temple");
        tracker.RecordEvent("Attend the temple");

        // Display goals and score
        tracker.DisplayGoals();
        tracker.DisplayScore();

        // Save progress
        tracker.SaveProgress("progress.dat");

        // Load progress
        GoalTracker newTracker = GoalTracker.LoadProgress("progress.dat");
        newTracker.DisplayGoals();
        newTracker.DisplayScore();
    }
}
