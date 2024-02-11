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
}