class VariablePayment : Payment
{
    public VariablePayment()
    {
        _isFixedPayment = false;
        
        Console.WriteLine("How much money do you spend on average each month for this item?");
        SetMonthlyPayment(float.Parse(Console.ReadLine()));
    }
}