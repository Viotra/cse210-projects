using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        Menu menu = new Menu();
        List<string> mainMenu = menu.GetMainMenu();
 
        string userInput = "";

        while (userInput != "6" && userInput != "quit")
        {
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
                            simple.Test(1);
                            goals.Add(simple);
                            break;
                        case "2":
                            //Eternal Goal
                            EternalGoal eternal = new EternalGoal();
                            eternal.Test(2);
                            break;
                        case "3":
                            //Checklist Goal

                            ChecklistGoal checklist = new ChecklistGoal();
                            checklist.Test(3);
                            break;
                    }
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
} 