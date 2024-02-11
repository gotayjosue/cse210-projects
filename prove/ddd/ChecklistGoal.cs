// Derived class for checklist goals

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        this.targetCount = targetCount;
        currentCount = 0;
    }

    // Override CalculatePoints method
    public override int CalculatePoints()
    {
        if (++currentCount == targetCount)
        {
            base.Complete();
            return base.Value + 500; // Bonus points
        }
        return base.Value;
    }

    // Override ToString method to display completion status
    public override string ToString()
    {
        return $"{(base.Completed ? "[X]" : $"Completed {currentCount}/{targetCount} times")} {base.Name}";
    }
}