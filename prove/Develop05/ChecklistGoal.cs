class ChecklistGoal : Goal
{
    private const int _goalType = 3;
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonusPoints;

    public ChecklistGoal()
        : base ()
        {

        }

    public override int RecordEvent()
    {
        if (_timesCompleted == _timesToComplete)
        {
            return base.RecordEvent() + _bonusPoints;
        }
        return base.RecordEvent();
    }
}