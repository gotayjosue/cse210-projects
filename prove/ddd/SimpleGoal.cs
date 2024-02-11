// Derived class for simple goals

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override int CalculatePoints()
    {
        return base.Value;
    }
}