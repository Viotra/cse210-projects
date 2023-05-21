class SaveLoadCSV
{
    //     public void SetFileName()
    // {
    //     Console.Write("Please enter the name of the file: ");
    //     _fileName = Console.ReadLine();
    // }

    public void BuildGoal()
    {
        
    }
    public void LoadGoalFile(AllGoals allGoal)
    {
        List<Goal> allGoals = allGoal.GetGoalList();
        Console.WriteLine("Which file would you like to load?");
        string fileName = Console.ReadLine();

        //This block will confirm if a user would like to open a new file and delete all current entries.
        if (allGoals.Count != 0)
        {
            Console.WriteLine("Warning, opening a new file will delete all current entries. \nDo you wish to continue? (yes/no) ");
            string confirm = Console.ReadLine();
            if (confirm == "yes" || confirm == "y")
            {
                allGoals.Clear();
            }
            else
            {
                return;
            }
        }
        
        bool firstLine = true;
        List<string> goalFile = System.IO.File.ReadAllLines(fileName).ToList();
        foreach (string goal in goalFile)
        {   
            if (firstLine == true)
            {
                allGoal.UpdateScore(int.Parse(goal));
                firstLine = false;
            }
            else
            {
                string[] goalElements = goal.Split("|");
                string name = goalElements[0];
                string description = goalElements[1];
                int points = int.Parse(goalElements[2]);
                bool accomplished = Boolean.Parse(goalElements[3]);
                int goalType = int.Parse(goalElements[4]);
                int timesCompleted;
                int timesToComplete;
                int bonusPoints;

                switch(goalType)
                {
                    case 1:
                        SimpleGoal simple = new SimpleGoal(name, description, points, accomplished);
                        allGoals.Add(simple);
                        break;
                    case 2:
                        timesCompleted = int.Parse(goalElements[5]);
                        EternalGoal eternal = new EternalGoal(name, description, points, timesCompleted);
                        allGoals.Add(eternal);
                        break;
                    case 3:
                        timesCompleted = int.Parse(goalElements[5]);
                        timesToComplete = int.Parse(goalElements[6]);
                        bonusPoints = int.Parse(goalElements[7]);
                        ChecklistGoal checklist = new ChecklistGoal(name, description, points, accomplished,
                            timesToComplete, timesCompleted, bonusPoints);
                        allGoals.Add(checklist);
                        break;
                }
            }
        }
        Console.Write("Your file has loaded.");
        Console.ReadLine();
    }
    //Need to alter SaveEntries class for Type Goal
    public void SaveGoalsFile(List<string> allGoalsList, int score)
    {
        Console.WriteLine("What would you like to name your file? ");
        string fileName = Console.ReadLine();

        //This block will confirm with user if they wish to overwrite an already existing save file.
        if (File.Exists(fileName))
        {
            Console.Write($"{fileName} already exists. \nWould you like to overwrite saved file? (yes/no) ");
            string confirm = Console.ReadLine();

            if (confirm == "yes" || confirm == "y")
            {
                
            }
            else
            {
                return;
            }
        }

        using (StreamWriter saveFile = new StreamWriter (fileName))
        {
            saveFile.WriteLine(score);
            foreach (string goal in allGoalsList)
            {
                saveFile.WriteLine(goal);
            }
        }
    }
}