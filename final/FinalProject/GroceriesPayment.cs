class GroceriesPayment : VariablePayment
{
    public GroceriesPayment(string paymentType = "Groceries") : base(paymentType)
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