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
            Console.WriteLine("How many extra points will be awarded for completing the goal? ");
            _bonusPoints = int.Parse(Console.ReadLine());
            _timesCompleted = 0;
            SetAccomplished(false);
        }
    public ChecklistGoal(string name, string description, int points, bool accomplished, int timesToComplete, int timesCompleted, int bonusPoints)
        :base(name, description, points, accomplished)
        {
            _timesToComplete = timesToComplete;
            _timesCompleted = timesCompleted;
            _bonusPoints = bonusPoints;
            
        }

    public override int RecordEvent()
    {
        _timesCompleted ++;
        if (_timesCompleted == _timesToComplete)
        {
            SetAccomplished(true);
            Animations animations = new Animations();
            int bonusPoints = animations.BonusPoints();
            return bonusPoints;
        }
        return base.RecordEvent();
    }
    public override string GetGoal()
    {
        return base.GetGoal() + string.Format("|{0}|{1}|{2}|{3}", _goalType, _timesCompleted, _timesToComplete,_bonusPoints);
    }
    public override int GetGoalType()
    {
        return _goalType;
    }
}