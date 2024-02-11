
public abstract class Goal
{
    private string name;
    private int value;
    private bool completed;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
        completed = false;
    }

    public string Name { get => name; }
    public int Value { get => value; }
    public bool Completed { get => completed; }

    // Method to mark goal as complete
    public void Complete()
    {
        completed = true;
    }

    // Method to calculate points
    public abstract int CalculatePoints();

    // Method to display goal status
    public override string ToString()
    {
        return $"{(completed ? "[X]" : "[ ]")} {name}";
    }
}