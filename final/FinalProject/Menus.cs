class Menus
{
    private List<string> _mainMenu = new List<string>()
    {
        "1. Create New Budget",
        "2. Show Budget",
        "3. Add Transaction",
        "4. All Transactions",
        "5. Adjust Budget",
        "6. Save Budget",
        "7. Load Budget",
        "8. Quit"
    };

    private List<string> _createBudgetMenu = new List<string>()
    {
        "1. Mortage Payment",
        "2. Phone Payment",
        "3. Internet Payment",
        "4. Insurance Payment",
        "5. Groceries Payment",
        "6. Gas Payment",
        "7. Electric Payment",
        "8. Water Payment",
        "9. Fuel Payment",
        "10. Entertainment Payment",
        "11. Income",
        "12. Tithing"
    };
    private List<string> _paymentInformation = new List<string>()
    {
        "What is the monthly payment amount? ",
        ""
    };
    public void DisplayMainMenu()
    {
        Console.Clear();
        foreach (string line in _mainMenu)
        {
            Console.WriteLine(line);
        }
    }

    public void DisplayCreateBudgetMenu()
    {
        Console.Clear();
        Console.WriteLine("When finished, enter \"back\":");
        foreach (string line in _createBudgetMenu)
        {
            Console.WriteLine(line);
        }
    }
}