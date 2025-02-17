public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;

    public override double GetDistance() => (_speed * GetMinutes()) / 60;

    public override double GetPace() => 60 / _speed;

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Cycling ({GetMinutes()} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}