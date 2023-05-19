class Menu
{
    private List<string> _menuOptions = new List<string>()
    {
        "1. Create New Goal",
        "2. List Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Event",
        "6. Quit"
    };
    private List<Goal> goals = new List<Goal>();
    private List<string> _gMenuOptions = new List<string>()
    {
        "1. SimpleGoal  Goal",
        "2. Eternal Goal",
        "3. Checklist Goal"
    };

    public void RunMenu()
    {
        string userInput = "";

        while (userInput != "6" && userInput != "quit")
        {
            Console.WriteLine("Menu Options:");

            foreach (string option in _menuOptions)
            {
                Console.WriteLine(option);
            }

            userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "1":
                case "create new goal":
                    RunGoalMenu();
                    break;
                case "2":
                case "list goals":
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(goal.GetGoal());
                    }
                    break;
                case "3":
                case "save goals":
                    break;
                case "4":
                case "load goals":
                    break;
                case "5":
                case "record event":
                    break;
                // case "6":
                // case "quit":
                //     break;
            }
        }
    }

    private void RunGoalMenu()
    {
        string userInput = "";

        Console.Clear();
        Console.WriteLine("Choose from one of the following goals:");

        foreach (string goal in _gMenuOptions)
        {
            Console.WriteLine(goal);
        }

        Console.Write("Goal #");
        userInput = Console.ReadLine();

        

        switch(userInput)
        {
            case "1":
                //SimpleGoal  Goal
                SimpleGoal  simple = new SimpleGoal ();
                simple.Test(1);
                goals.Add(simple);
                break;
            case "2":
                //Eternal Goal
                Eternal eternal = new Eternal();
                eternal.Test(2);
                break;
            case "3":
                //Checklist Goal

                Checklist checklist = new Checklist();
                checklist.Test(3);
                break;
        }
    }

    
}