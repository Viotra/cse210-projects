class FixedPayment : Payment
{
    public FixedPayment(string paymentType) : base(paymentType)
    {
        _isFixedPayment = true;
        SetMonthlyPayment();
    }

    public FixedPayment(string paymentType, float spendingLimit, float paymentAmount, float availableFunds
        , float monthlyPayment, bool inLimit, bool isFixedPayment = true) : base(paymentType
        , spendingLimit, paymentAmount, availableFunds, monthlyPayment
        , inLimit, isFixedPayment)
        {
            
        }

    public override void SetMonthlyPayment()
    {
        Console.WriteLine("How much is your monthly payment? ");
        _monthlyPayment = float.Parse(Console.ReadLine());
    }
}