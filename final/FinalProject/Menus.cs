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

    public void DisplayAdjustmentItems(Payment payment)
    {
        float spendingLimit = payment.GetSpendingLimit();
        float actualAmount = payment.GetPaymentAmount();
        float availableFunds = payment.GetAvailableFunds();

        Console.WriteLine($"1. Spending Limit: {spendingLimit}");
        Console.WriteLine($"2. Amount Spent: {actualAmount}");
        Console.WriteLine($"3. Amount Available: {availableFunds}");
        if (payment is VariablePayment)
        {
            VariablePayment variablePayment = (VariablePayment) payment;
            float unnecessarySpending = variablePayment.GetUnnecessaryPayment();
            
            Console.WriteLine($"4. Unnecessary Spending: {unnecessarySpending}");
        }
    }
    public void DisplayAllBudgetItems(Budget budget)
    {
        List<Payment> allPayments = budget.GetAllPayments();
        int i, budgetLength;
        budgetLength = allPayments.Count;

        for (i = 0; i < budgetLength; i++)
        {  
            string paymentType = allPayments[i].GetPaymentType();    
            Console.WriteLine($"{i + 1}. {paymentType}");                                                  
        }
        Console.WriteLine($"{budgetLength + 1}. Income");
    }
}