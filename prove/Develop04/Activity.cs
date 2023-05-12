class Activity
{
    protected string _activityName;
    private string _startingMessage = "Now beginning ";
    protected string _endingMessage = "Well done.";
    protected string instuctions;

    protected int duration;

    public int GetDuration()
    {
        return duration;
    }

    public Activity(string name)
    {
        _activityName = name;
    }
    public void Spinner()
    {

    }

    public void CountdownTimer()
    {

    }

    protected string StartingMessage
    {
        get{return _startingMessage + _activityName;}
    }
}