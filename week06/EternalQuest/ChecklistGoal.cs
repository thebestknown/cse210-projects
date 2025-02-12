public class ChecklistGoal : Goal
{
    public int AmountCompleted { get; set; }
    public int Target { get; private set; }
    public int Bonus { get; private set; }

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        Target = target;
        Bonus = bonus;
        AmountCompleted = 0;
    }

    public override void RecordEvent()
    {
        AmountCompleted++;
        if (AmountCompleted == Target)
        {
            Console.WriteLine($"Congratulations! You have earned {Points + Bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {Points} points!");
        }
    }

    public override bool IsComplete()
    {
        return AmountCompleted >= Target;
    }

    public override string GetDetailsString()
    {
        return ($"{(IsComplete() ? "[X]" : "[ ]")} {ShortName} ({Description}) -- Currently completed: {AmountCompleted}/{Target}");
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{ShortName},{Description},{Points},{Bonus},{Target},{AmountCompleted}";
    }
}
