class Activity
{
    protected string _activityName;
    private string _startingMessage = "Now beginning ";
    private string _endingMessage = "Well done.";
    protected string _instructions;

    private int _duration;

    public int GetDuration()
    {
        Console.Write("How many minutes would you like to spend performing this activity? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    public Activity(string name)
    {
        _activityName = name;
    }

    protected string StartingMessage
    {
        get{return _startingMessage + _activityName;}
    }

    protected void WriteEndMessage()
    {
        Console.Write(_endingMessage);
    }

    public void StartActivity()
    {
        Console.Clear();   
        Console.WriteLine(StartingMessage);
        Thread.Sleep(3000);
        Console.WriteLine(_instructions);
        Thread.Sleep(3000);
    }
}