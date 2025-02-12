public class SimpleGoal : Goal
{
    public bool IsCompleteFlag { get; set; }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        IsCompleteFlag = false;
    }

    public override void RecordEvent()
    {
        IsCompleteFlag = true;
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
    }

    public override bool IsComplete()
    {
        return IsCompleteFlag;
    }

    public override string GetDetailsString()
    {
        return ($"{(IsCompleteFlag ? "[X]" : "[ ]")} {ShortName} ({Description})");
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{ShortName},{Description},{Points},{IsCompleteFlag}";
    }
}
