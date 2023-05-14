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

            Console.Clear();

            foreach (string item in _menuItems)
            {
                Console.WriteLine(item);
            }

            userInput = Console.ReadLine().ToLower();

            Animations animation = new Animations();

            switch(userInput)
            {
                case "1":
                case "breathing activity":
                    animation.RunBlinkAnimation();
                    Breathing breathing = new Breathing();
                    breathing.RunBreathingActivity();
                    break;
                case "2":
                case "reflection activity":
                    animation.RunBlinkAnimation();
                    Reflection reflection = new Reflection();
                    reflection.ReflectionActivity();
                    break;
                case "3":
                case "listing activity":
                    animation.RunBlinkAnimation();
                    Listing listing = new Listing();
                    listing.RunListingActivity();
                    break;
            }
        }
    }
}