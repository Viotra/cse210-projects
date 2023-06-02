class Payment
{
    private string _paymentType;
    private float _monthlyPayment, _percentageOfIncome, _spendingLimit, _paymentAmount;
    protected bool _isFixedPayment;
    private bool _inLimit = true;

    DateOnly _paymentDate = new DateOnly();

    public Payment()
    {
        _paymentType = this.GetType().Name;
    }

    public bool GetInLimit()
    {
        return _inLimit;
    }

    public void SetInLimit()
    {
        if (_paymentAmount > _spendingLimit)
        {
            _inLimit = false;
        }
    }
    // public void DisplayTransaction()
    // {
    //     string transaction = string.Format("{0} for ${1} on {2}", _paymentType, _paymentAmount, _paymentDate);
    //     Console.WriteLine(transaction);
    // }
    public void SetMonthlyPayment(float monthlyPayment)
    {
        _monthlyPayment = monthlyPayment;
    }    

    public float GetMonthlyPayment()
    {
        return _monthlyPayment;
    }

    public void ReduceSpendingLimit(float paymentAmount)
    {
        _spendingLimit -= paymentAmount;
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

    public float GetPaymentAmount()
    {
        return _paymentAmount;
    }
}