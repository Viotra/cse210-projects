class FixedPayment : Payment
{
    public FixedPayment()
    {
        _isFixedPayment = true;
        
        Console.WriteLine("What is your monthly payment? ");
        SetMonthlyPayment(float.Parse(Console.ReadLine()));
    }
}