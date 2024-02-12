using System.Resources;

public class ChecklistGoal : Goal 
{
    private int _bonus = 0;
    private int _target = 0;
    private int _amountCompleted = 0;

    /* Getters */
    public int GetBonus() {
        
        return _bonus;
    }

    public int GetTarget() {

        return _target;
    }

    public int GetAmountCompleted() {

        return _amountCompleted;
    }

    /* Setters */

    public void SetBonus(int bonus) {

        _bonus = bonus;
    }

    public void SetTarget(int target) {

        _target = target;
    }

    public void SetAmountCompleted(int amountCompleted) {

        _amountCompleted = amountCompleted;

    }

    public override void DisplayInfo()
    {
        SetAmountCompleted(0);
        Console.WriteLine("What is the name of your goal? ");
        string name3 = Console.ReadLine();
        SetShortName(name3);
        Console.WriteLine("What is a short description of it?");
        string description3 = Console.ReadLine();
        SetDescription(description3);
        Console.WriteLine("What is the amount of points associated with this goal?");;
        string points3 = Console.ReadLine();
        int pointInt3 = int.Parse(points3);
        SetPoints(pointInt3);
        Console.WriteLine("How many times does this goal need to be accomplish for a bonus?");
        string times = Console.ReadLine();
        int timesInt = int.Parse(times);
        SetTarget(timesInt);
        Console.WriteLine("What is the bonus for accomplish in that many times?");
        string bonus = Console.ReadLine();
        int bonusInt = int.Parse(bonus);
        SetBonus(bonusInt);
    }
}