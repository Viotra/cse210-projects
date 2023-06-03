class VariablePayment : Payment
{
    protected float _maxPayment;
    private float _unnecessaryPayment = 0;

    public VariablePayment(string paymentType) : base(paymentType)
    {
        _isFixedPayment = false;
        SetMonthlyPayment();
        SetMaxPayment();
    }

    public override void SetMonthlyPayment()
    {
        Console.WriteLine("How much money do you spend on average each month for this item?");
        _monthlyPayment = float.Parse(Console.ReadLine());
        
    }
    public virtual void SetMaxPayment()
    {
        Console.WriteLine("What do you believe is the maximum you would pay each month?");
        _maxPayment = float.Parse(Console.ReadLine());
    }

    public override void SetInLimit()
    {
        if (GetPaymentAmount() > _maxPayment)
        {
            _inLimit = false;
        }
    }

    public float GetMaxPayment()
    {
        return _maxPayment;
    }

    public float GetUnnecessaryPayment()
    {
        return _unnecessaryPayment;
    }
    public void AddUnnecessaryPayment(float unnecessaryPayment)
    {
        _unnecessaryPayment += unnecessaryPayment;
    }
}