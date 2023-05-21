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
    public List<Goal> GetGoalList()
    {
        return _goals;
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
            int goalType = int.Parse(goalElements[4]);
            int timesCompleted;
            int timesToComplete;

            if (accomplished == true)
            {
                statusSymbol = "[x]";
            }

            switch(goalType)
                {
                    case 1:
                        Console.WriteLine(string.Format("#{0} {1} Name: {2} Description: {3}",
                        i + 1, statusSymbol, name, description));
                        break;
                    case 2:
                        timesCompleted = int.Parse(goalElements[5]);
                        Console.WriteLine(string.Format("#{0} {1} Name: {2} Description: {3} "
                        + "Times Completed: {4}", i + 1, statusSymbol, name, description,
                        timesCompleted));
                        break;
                    case 3:
                        timesCompleted = int.Parse(goalElements[5]);
                        timesToComplete = int.Parse(goalElements[6]);
                        Console.WriteLine(string.Format("#{0} {1} Name: {2} Description: {3} "
                        + "Times Completed: {4}/{5}", i + 1, statusSymbol, name, description,
                        timesCompleted, timesToComplete));
                        break;
                }
        }
    }
}