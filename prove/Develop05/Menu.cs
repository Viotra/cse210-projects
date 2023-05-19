class Menu
{
    private List<string> _mainMenu = new List<string>()
    {
        "1. Create New Goal",
        "2. List Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Event",
        "6. Quit"
    };
   
    private List<string> _goalMenu = new List<string>()
    {
        "1. SimpleGoal  Goal",
        "2. Eternal Goal",
        "3. Checklist Goal"
    };

    public List<string> GetMainMenu()
    {
        return _mainMenu;
    }

    public List<string> GetGoalMenu()
    {
        return _goalMenu;
    }

    
}