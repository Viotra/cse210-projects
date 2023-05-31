class Payment
{
    private string _paymentType;
    private float _monthlyPayment, _percentageOfIncome, _spendingLimit, _paymentAmount;
    protected bool _isFixedPayment;

    DateOnly _paymentDate = new DateOnly();

    public Payment()
    {
        _paymentType = this.GetType().Name;
    }

    public void DisplayTransaction()
    {
        string transaction = string.Format("{0} for ${1} on {2}", _paymentType, _paymentAmount, _paymentDate);
        Console.WriteLine(transaction);
    }
    public void SetMonthlyPayment(float monthlyPayment)
    {
        _monthlyPayment = monthlyPayment;
    }    

    public float GetMonthlyPayment()
    {
        return _monthlyPayment;
    }

    public string GetPaymentType()
    {
        return _paymentType;
    }

    public void SetPercentageOfIncome(float incomePercentage)
    {
        _percentageOfIncome = incomePercentage;
    }

    public float GetPercentageOfIncome()
    {
        return _percentageOfIncome;
    }

    public void SetSpendingLimit(float spendingLimit)
    {
        _spendingLimit = spendingLimit;
    }

    public float GetSpendingLimit()
    {
        return _spendingLimit;
    }
}