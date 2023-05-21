//Added Animations class for spinner and Bonus Points animation
using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();
        SaveLoadCSV saveLoad = new SaveLoadCSV();
        Menu menu = new Menu();
        List<string> mainMenu = menu.GetMainMenu();

        Animations animations = new Animations();
        
 
        string userInput = "";

        while (userInput != "6" && userInput != "quit")
        {
            int score = allGoals.GetScore();
            Console.Clear();
            animations.Spinner();
            Console.WriteLine(score);
            Console.WriteLine();
            Console.WriteLine("Menu Options:");

            foreach (string option in mainMenu)
            {
                Console.WriteLine(option);
            }

            userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "1":
                case "create new goal":

                    List<string> goalMenu = menu.GetGoalMenu();
                    Console.Clear();
                    animations.Spinner();
                    Console.WriteLine("Choose from one of the following goals:");

                    foreach (string option in goalMenu)
                    {
                        Console.WriteLine(option);
                    }

                    Console.Write("Goal #");
                    userInput = Console.ReadLine();      

                    switch(userInput)
                    {
                        case "1":
                            //SimpleGoal  Goal
                            SimpleGoal  simple = new SimpleGoal ();
                            allGoals.AddGoal(simple);
                            break;
                        case "2":
                            //Eternal Goal
                            EternalGoal eternal = new EternalGoal();
                            allGoals.AddGoal(eternal);
                            break;
                        case "3":
                            //Checklist Goal

                            ChecklistGoal checklist = new ChecklistGoal();
                            allGoals.AddGoal(checklist);
                            break;
                    }
                    break;
                case "2":
                case "list goals":
                    Console.Clear();
                    animations.Spinner();
                    allGoals.DisplayGoals();
                    Console.ReadKey();
                    break;
                case "3":
                case "save goals":
                    Console.Clear();
                    animations.Spinner();
                    List<string> sGoals = new List<string>();
                    foreach(Goal aGoal in allGoals.GetGoalList())
                    {
                        sGoals.Add(aGoal.GetGoal());
                    }
                    saveLoad.SaveGoalsFile(sGoals, score);
                    break;
                case "4":
                case "load goals":
                    Console.Clear();
                    animations.Spinner();
                    saveLoad.LoadGoalFile(allGoals);
                    break;
                case "5":
                case "record event":
                    Console.Clear();
                    animations.Spinner();
                    Console.Write("For which goal would you like to record an event? ");
                    allGoals.DisplayGoals();
                    int newUserInput = int.Parse(Console.ReadLine()) - 1; 
                    Goal goal = allGoals.GetGoal(newUserInput);
                    Console.WriteLine(goal.GetType());
                    allGoals.UpdateScore(goal.RecordEvent());
                    // if (goal.IsAccomplished() == true)
                    // {
                        
                    // }
                    break;
                // case "6":
                // case "quit":
                //     break;
            }
        }       
    }
} 