// Class to manage goals and scoring

public class GoalTracker
{
    private List<Goal> goals;
    private int score;

    public GoalTracker()
    {
        goals = new List<Goal>();
        score = 0;
    }

    // Method to add a new goal
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    // Method to record an event and update score
    public void RecordEvent(string goalName)
    {
        foreach (Goal goal in goals)
        {
            if (goal.Name == goalName)
            {
                score += goal.CalculatePoints();
                break;
            }
        }
    }

    // Method to display all goals
    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal);
        }
    }

    // Method to display current score
    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {score}");
    }

    // Method to save progress
    public void SaveProgress(string filename)
    {
        using (FileStream stream = new FileStream(filename, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
        }
    }

    // Method to load progress
    public static GoalTracker LoadProgress(string filename)
    {
        using (FileStream stream = new FileStream(filename, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return (GoalTracker)formatter.Deserialize(stream);
        }
    }
}