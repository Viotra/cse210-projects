class FixedPayment : Payment
{
    public FixedPayment(string paymentType) : base(paymentType)
    {
        _isFixedPayment = true;
        SetMonthlyPayment();
    }

    public override void SetMonthlyPayment()
    {
        Console.WriteLine("How much is your monthly payment? ");
        _monthlyPayment = float.Parse(Console.ReadLine());
    }
}