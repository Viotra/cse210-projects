public abstract class Goal
{
    //Goals will be simple, Eternal, or checklist

    private string _name, _description;
    private int _points;
    private bool _accomplished;
    private List<string> goals = new List<string>();

    public Goal()
    {
        CreateNewGoal();
        SetAccomplished(false);
    }

    public Goal(string name, string description, int points, bool accomplished)
    {
        _name = name;
        _description = description;
        _points = points;
        SetAccomplished(accomplished);

    }

    public virtual string GetGoal()
    {        
        return string.Format("{0}|{1}|{2}|{3}",_name,_description,_points, _accomplished);
    }

    public virtual int RecordEvent()
    {
        return _points;
    }
    protected void SetAccomplished(bool accomplished)
    {
        _accomplished = accomplished;
    }

    private void CreateNewGoal()
    {
        Console.Write("What is the name of this goal? ");
        _name = Console.ReadLine();
        Console.Write("What is the purpose of this goal? ");
        _description = Console.ReadLine();
        Console.Write("How many points would you like to assign to this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    public abstract int GetGoalType();
}