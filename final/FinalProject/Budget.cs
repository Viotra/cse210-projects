class Budget
{
    private List<Payment> _allPayments = new List<Payment>();
    private List<string> _unnecessaryPayment = new List<string>();
    private bool _inBudget;
    //private List<Payment> _savingsGoals = new List<Payment>(); May be able to just create a method to show this.
    private float _monthlyIncome;
    private float _leftOverFunds;

    public void AddPayment(Payment payment)
    {
        _allPayments.Add(payment);
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
            float paymentAmount = payment.GetMonthlyPayment();

            leftOverFunds -= paymentAmount;
        }
        _leftOverFunds = leftOverFunds;
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

    public bool GetInBudget()
    {
        return _inBudget;
    }
}