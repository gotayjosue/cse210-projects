public class SimpleGoal : Goal
{

    public override void DisplayInfo()
    {
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        SetShortName(name);
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.WriteLine("What is the amount of points associated with this goal?");;
        string points = Console.ReadLine();
        int pointInt = int.Parse(points);
        SetPoints(pointInt);
    }
}