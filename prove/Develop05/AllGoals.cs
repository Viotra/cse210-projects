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
            var goalElements = _goals[i].GetGoal();
            string name = goalElements.Item1;
            string description = goalElements.Item2;
            bool accomplished = goalElements.Item4;
            Console.WriteLine(string.Format("{3}. Name: {0} Description: {1} Completed: {2}", name, description, accomplished, i));
        }
    }
}