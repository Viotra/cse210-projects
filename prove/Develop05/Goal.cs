public abstract class Goal
{
    //Goals will be simple, Eternal, or checklist

    private string _name, _description, _points;
    private bool _accomplished;
    private List<string> goals = new List<string>();

    public Goal()
    {
        var newGoal = CreateNewGoal();
        string name = newGoal.Item1;
        string description = newGoal.Item2;
        string points = newGoal.Item3;

        _name = name;
        _description = description;
        _points = points;
        _accomplished = false;
    }

    public abstract string GetGoal();

    public void Test(int number)
    {
        Console.WriteLine($"Test {number.ToString()} successful!");
    }
    protected void SetAccomplished(bool accomplished)
    {
        _accomplished = accomplished;
    }

    private (string, string, string) CreateNewGoal()
    {
        string name, description, points;

        Console.Write("What is the name of this goal? ");
        name = Console.ReadLine();
        Console.Write("What is the purpose of this goal? ");
        description = Console.ReadLine();
        Console.Write("How many points would you like to assign to this goal? ");
        points = Console.ReadLine();

        return (name, description, points);
    }
}