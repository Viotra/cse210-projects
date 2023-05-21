using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();
        SaveLoadCSV saveLoad = new SaveLoadCSV();
        Menu menu = new Menu();
        List<string> mainMenu = menu.GetMainMenu();
 
        string userInput = "";

        while (userInput != "6" && userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(allGoals.GetScore());
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
                    allGoals.DisplayGoals();
                    Console.ReadKey();
                    break;
                case "3":
                case "save goals":
                    Console.Clear();
                    List<string> sGoals = new List<string>();
                    foreach(Goal aGoal in allGoals.GetGoalList())
                    {
                        sGoals.Add(aGoal.GetGoal());
                    }
                    saveLoad.SaveGoalsFile(sGoals);
                    break;
                case "4":
                case "load goals":
                    Console.Clear();
                    saveLoad.LoadGoalFile(allGoals.GetGoalList());
                    break;
                case "5":
                case "record event":
                    Console.Clear();
                    Console.Write("For which goal would you like to record an event? ");
                    allGoals.DisplayGoals();
                    int newUserInput = int.Parse(Console.ReadLine()) - 1; 
                    Goal goal = allGoals.GetGoal(newUserInput);
                    Console.WriteLine(goal.GetType());
                    allGoals.UpdateScore(goal.RecordEvent());
                    break;
                // case "6":
                // case "quit":
                //     break;
            }
        }       
    }
} 