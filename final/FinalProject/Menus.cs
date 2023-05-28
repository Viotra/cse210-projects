class Menus
{
    private List<string> _mainMenu = new List<string>()
    {
        "1. Create New Budget",
        "2. Add Transaction",
        "3. All Transactions",
        "4. Adjust Budget",
        "5. Save Budget",
        "6. Load Budget",
        "7. Quit"
    };

    public void DisplayMainMenu()
    {
        foreach (string line in _mainMenu)
        {
            Console.WriteLine(line);
        }
    }

    
}