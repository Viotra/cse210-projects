class GroceriesPayment : VariablePayment
{
    public GroceriesPayment(string paymentType = "Groceries") : base(paymentType)
    {

    }

    public GroceriesPayment(string paymentType, float spendingLimit, float paymentAmount, float availableFunds
        , float monthlyPayment, bool inLimit, float maxPayment, bool isFixedPayment = false) : base(
        paymentType, spendingLimit, paymentAmount, availableFunds, monthlyPayment, inLimit, maxPayment, 
        isFixedPayment)
        {
            
        }

    public override void SetPaymentAmount(float paymentAmount)
    {
        base.SetPaymentAmount(paymentAmount);
        Console.WriteLine("How much money went to something unneeded such as junkfood or expesives groceries"
        + " you wouldn't normally buy?");
        float unnecessarySpending = float.Parse(Console.ReadLine());
        AddUnnecessaryPayment(unnecessarySpending);
    }

    //Create a goal here which would review any junkfood purchased, set junkfood amounts to unnecessary expense
}