public abstract class Payment
{
    private string _paymentType;
    private float _percentageOfIncome, _spendingLimit, _paymentAmount, _availableFunds;
    protected float _monthlyPayment;
    protected bool _isFixedPayment;
    protected bool _inLimit = true;

    public Payment(string paymentType)
    {
        _paymentType = paymentType;
    }

    public bool GetInLimit()
    {
        return _inLimit;
    }

    public virtual void SetInLimit()
    {
        if (_paymentAmount > _spendingLimit)
        {
            _inLimit = false;
        }
    }

    public bool GetIsFixedPayment()
    {
        return _isFixedPayment;
    }
    // public void DisplayTransaction()
    // {
    //     string transaction = string.Format("{0} for ${1} on {2}", _paymentType, _paymentAmount, _paymentDate);
    //     Console.WriteLine(transaction);
    // }
    public abstract void SetMonthlyPayment();

    public float GetMonthlyPayment()
    {
        return _monthlyPayment;
    }

    public void SetAvailableFunds(float monthlyPayment)
    {
        _availableFunds = monthlyPayment;
    }

    public void UpdateAvailableFunds(float payment)
    {
        _availableFunds -= payment;
    }
    
    public float GetAvailableFunds()
    {
        return _availableFunds;
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

    public virtual void SetPaymentAmount(float paymentAmount)
    {
        _paymentAmount = paymentAmount;
    }
}