public class EternalGoal : Goal 
{
    public override void DisplayInfo()
    {
        Console.WriteLine("What is the name of your goal? ");
        string name2 = Console.ReadLine();
        SetShortName(name2);
        Console.WriteLine("What is a short description of it?");
        string description2 = Console.ReadLine();
        SetDescription(description2);
        Console.WriteLine("What is the amount of points associated with this goal?");;
        string points2 = Console.ReadLine();
        int pointInt2 = int.Parse(points2);
        SetPoints(pointInt2);
    }
}