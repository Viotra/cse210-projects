class GroceriesPayment : VariablePayment
{
    public GroceriesPayment(string paymentType = "Groceries") : base(paymentType)
    {

    }

    //Create a goal here which would review any junkfood purchased, set junkfood amounts to unnecessary expense
}