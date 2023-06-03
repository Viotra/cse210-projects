class VariablePayment : Payment
{
    private string _goal;
    public VariablePayment(string paymentType) : base(paymentType)
    {
        _isFixedPayment = false;

        SetMonthlyPayment();
    }

    public override void SetMonthlyPayment()
    {
        Console.WriteLine("How much money do you spend on average each month for this item?");
        _monthlyPayment = float.Parse(Console.ReadLine());
    }
    public virtual void SetGoal()
    {

    }

    public string GetGoal()
    {
        return _goal;
    }
}