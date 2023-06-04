class Budget
{
    private List<Payment> _allPayments = new List<Payment>();
    private float _totalUnnecessaryPayment = 0;
    private bool _inBudget, _isTithePayer = false;
    //private List<Payment> _savingsGoals = new List<Payment>(); May be able to just create a method to show this.
    private float _monthlyIncome, _currentIncome;
    private float _leftOverFunds;

    public Budget()
    {

    }

    public Budget(float monthlyIncome, float currentIncome, float leftOverFunds, bool isTithePayer)
    {
        _monthlyIncome = monthlyIncome;
        _currentIncome = currentIncome;
        _leftOverFunds = leftOverFunds;
        _isTithePayer = isTithePayer;
    }

    public List<Payment> GetAllPayments()
    {
        return _allPayments;
    }

    public float GetMonthlyIncome()
    {
        return _monthlyIncome;
    }
    public void AddPayment(Payment payment)
    {
        _allPayments.Add(payment);
    }
    
    public void AddIncome(float income)
    {
        _currentIncome += income;
    }

    public void SetCurrentIncome(float income)
    {
        _currentIncome = income;
    }

    public void SubtractIncome(float income)
    {
        _currentIncome -= income;
    }
    public void SetMonthlyIncome()
    {
        Console.WriteLine("On average, how much money do you bring home each month? ");
        float income = float.Parse(Console.ReadLine());
        _monthlyIncome = income;
    }

    public void CalculatePercentageOfIncome()
    {
        foreach (Payment payment in _allPayments)
        {
            float paymentAmount = payment.GetMonthlyPayment();
            float incomePercentage = paymentAmount / _monthlyIncome * 100;

            payment.SetPercentageOfIncome(incomePercentage);
            Console.WriteLine($"Your {payment.GetPaymentType()} is ${payment.GetMonthlyPayment()}."
            + $" This is {payment.GetPercentageOfIncome()}% of your total income.");
        }
    }

    public void SetLeftOverFunds()
    {
        float leftOverFunds = _monthlyIncome;

        foreach (Payment payment in _allPayments)
        {
            float paymentAmount = payment.GetSpendingLimit();

            leftOverFunds -= paymentAmount;
        }
        _leftOverFunds = leftOverFunds;
    }

    public void SetIsTithePayer()
    {
        Console.WriteLine("Do you pay tithing? ");
        string userInput = Console.ReadLine();

        if (userInput == "yes" || userInput == "y")
        {
            _isTithePayer = true;
        }
    }

    public bool GetIsTithePayer()
    {
        return _isTithePayer;
    }
    public void SetInBudget()
    {
        _inBudget = true;

        foreach (Payment payment in _allPayments)
        {
            if (payment.GetSpendingLimit() < 0)
            {
                _inBudget = false;
            }
        }
    }

    public float GetCurrentIncome()
    {
        return _currentIncome;
    }

    public float GetLeftOverFunds()
    {
        return _leftOverFunds;
    }

    public bool GetInBudget()
    {
        return _inBudget;
    }

    public void DisplayBudget()
    {
        Console.Clear();
        Console.WriteLine("Each Budget item is displayed below: ");
        Console.WriteLine();
        Console.WriteLine($"Income: {_currentIncome}/{_monthlyIncome}");

        foreach (Payment payment in _allPayments)
        {
            string paymentType = payment.GetPaymentType();
            float spendingLimit = payment.GetSpendingLimit();
            float actualAmount = payment.GetPaymentAmount();
            float availableFunds = payment.GetAvailableFunds();
            bool inLimit = payment.GetInLimit();
            _totalUnnecessaryPayment = 0;

            if (payment is VariablePayment)
            {
                VariablePayment variablePayment = (VariablePayment) payment;
                _totalUnnecessaryPayment += variablePayment.GetUnnecessaryPayment();
            }

            if (payment is Tithing)
            {
                float monthlyPayment = payment.GetMonthlyPayment();
                Console.WriteLine($"{paymentType} Spending Limit: ${actualAmount}/${monthlyPayment}");
            }
            else
            {
                Console.WriteLine($"{paymentType} Spending Limit: ${actualAmount}/${spendingLimit} Available Funds: ${availableFunds} In Limits: {inLimit}");
            }

            if (payment is FuelPayment)
            {
                FuelPayment fuelPayment = (FuelPayment) payment;
                int fuelUps = fuelPayment.GetFuelUps();
                int fuelUpGoal = fuelPayment.GetFuelUpGoal();
                Console.WriteLine($"Fuel up goal: {fuelUps} / {fuelUpGoal}");
            }
        }
        Console.WriteLine($"Estimated money that could have been saved: {_totalUnnecessaryPayment}");

        Console.ReadLine();
    }
}