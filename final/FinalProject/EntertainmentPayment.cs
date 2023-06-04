class EntertainmentPayment : VariablePayment
{
    public EntertainmentPayment(string paymentType = "Entertainment") : base(paymentType)
        {

        }

     public EntertainmentPayment(string paymentType, float spendingLimit, float paymentAmount, float availableFunds
        , float monthlyPayment, bool inLimit, float maxPayment, bool isFixedPayment = false) : base(
        paymentType, spendingLimit, paymentAmount, availableFunds, monthlyPayment, inLimit, maxPayment, 
        isFixedPayment)
        {
            
        }

    public override void SetMaxPayment()
    {
        Console.WriteLine("As entertainment is harder to put down for an exact amount, please enter an upper spending "
        + "limit as well.");
        _maxPayment = float.Parse(Console.ReadLine());
    }
    public override void SetPaymentAmount(float paymentAmount)
    {
        base.SetPaymentAmount(paymentAmount);

    }
}