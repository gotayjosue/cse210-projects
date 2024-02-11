// Derived class for eternal goals

public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override int CalculatePoints()
    {
        return base.Value;
    }
}