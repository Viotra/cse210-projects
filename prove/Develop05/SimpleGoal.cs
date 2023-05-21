class SimpleGoal : Goal
{
    const int _goalType = 1;
    public SimpleGoal()
        : base ()
        {
            SetAccomplished(false);
        }
    public SimpleGoal(string name, string description, int points, bool accomplished)
        :base(name, description, points, accomplished)
        {

        }

    public override int RecordEvent()
    {
        SetAccomplished(true);
        return base.RecordEvent();
    }
    public override string GetGoal()
    {
        return base.GetGoal() + string.Format("|{0}", _goalType);
    }
    public override int GetGoalType()
    {
        return _goalType;
    }
}