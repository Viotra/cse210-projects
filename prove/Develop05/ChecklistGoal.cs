class ChecklistGoal : Goal
{
    private const int _goalType = 3;
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonusPoints;

    public ChecklistGoal()
        : base ()
        {
            Console.WriteLine("How many times will you be performing this task until complete? ");
            _timesToComplete = int.Parse(Console.ReadLine());
            _timesCompleted = 0;
            SetAccomplished(false);
        }
    public ChecklistGoal(string name, string description, int points, bool accomplished, int timesToComplete, int timesCompleted)
        :base(name, description, points, accomplished)
        {
            int _timesToComplete = timesToComplete;
            int _timesCompleted = timesCompleted;
        }

    public override int RecordEvent()
    {
        _timesCompleted ++;
        if (_timesCompleted == _timesToComplete)
        {
            return base.RecordEvent() + _bonusPoints;
        }
        return base.RecordEvent();
    }
    public override string GetGoal()
    {
        return base.GetGoal() + string.Format("{0}|{1}|{2}", _goalType, _timesCompleted, _timesToComplete);
    }
}