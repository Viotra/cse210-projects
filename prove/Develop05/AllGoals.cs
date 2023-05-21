class AllGoals
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public int GetScore()
    {
        return _score;
    }
    public Goal GetGoal(int goalNumber)
    {
        return _goals[goalNumber];
    }
    public void UpdateScore(int points)
    {
        _score += points;
    }
    public void DisplayGoals()
    {
        for(int i = 0; i < _goals.Count; i++)
        {
            string statusSymbol = "[ ]";
            string goal = _goals[i].GetGoal();
            string[] goalElements = goal.Split("|");
            string name = goalElements[0];
            string description = goalElements[1];
            bool accomplished = Boolean.Parse(goalElements[3]);
            if (accomplished == true)
            {
                statusSymbol = "[x]";
            }
            Console.WriteLine(string.Format("#{3} {4} Name: {0} Description: {1} Completed: {2}", name, description, accomplished, i, statusSymbol));
        }
    }
}