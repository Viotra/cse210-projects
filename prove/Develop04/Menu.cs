class Menu
{
    private List<string> _menuItems = new List<string>()
    {
        "1. Breathing Activity",
        "2. Reflection Activity",
        "3. Listing Activity",
        "4. Quit"
    };

    public void MenuStart()
    {
        string userInput = "";

        while (userInput != "4" && userInput != "quit")
        {

            foreach (string item in _menuItems)
            {
                Console.WriteLine(item);
            }

            userInput = Console.ReadLine().ToLower();

            Console.WriteLine(userInput);
            Console.ReadLine();

            switch(userInput)
            {
                case "1":
                case "breathing activity":
                    Breathing breathing = new Breathing();
                    break;
                case "2":
                case "reflection activity":
                    Reflection reflection = new Reflection();
                    break;
            }
        }
    }
}