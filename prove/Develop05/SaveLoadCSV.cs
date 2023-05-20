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
    public void LoadGoalFile(int goalType, List<Goal> goalsList)
    {
        Console.WriteLine("Which file would you like to load?");
        string fileName = Console.ReadLine();

        //This block will confirm if a user would like to open a new file and delete all current entries.
        if (goalsList.Count != 0)
        {
            Console.WriteLine("Warning, opening a new file will delete all current entries. \nDo you wish to continue? (yes/no) ");
            string confirm = Console.ReadLine();
            if (confirm == "yes" || confirm == "y"){
                goalsList.Clear();
            }
        }

        List<string> goalFile = System.IO.File.ReadAllLines(fileName).ToList();
        Console.Write("Your file has loaded.");
        Console.ReadLine();
    }
    //Need to alter SaveEntries class for Type Goal
    public void SaveEntries(List<Goal> allGoals)
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
            foreach (Goal goal in allGoals)
            {
                saveFile.WriteLine(goal.GetGoal());
            }
        }
    }
}