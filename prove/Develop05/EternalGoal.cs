class EternalGoal : Goal
{
    private const int _goalType = 2;
    private int _timesCompleted;

    public EternalGoal()
        : base ()
        {
            SetAccomplished(false);
            _timesCompleted = 0;
        }
    public EternalGoal(string name, string description, int points, int timesCompleted)
        : base(name, description, points, false)
        {
            _timesCompleted = timesCompleted;
        }

    public override string GetGoal()
    {
        return base.GetGoal() + string.Format("|{0}|{1}", _goalType, _timesCompleted);
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted % 5 == 0)
        {
            return base.RecordEvent() + _timesCompleted;
        }
        else
        {
            return base.RecordEvent();
        }
    }
    public override int GetGoalType()
    {
        return _goalType;
    }
}