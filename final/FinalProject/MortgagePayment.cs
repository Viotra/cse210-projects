class MortgagePayment : Payment
{
    private float _interestRate, _pricipleAmount, _extraToPriciple;
    private int _numberOfPayments;
    private DateOnly _payOffDate = new DateOnly();

    public MortgagePayment()
        : base()
        {
            Console.WriteLine("How much is left on your loan?");
            _pricipleAmount = float.Parse(Console.ReadLine());
            Console.WriteLine("How many more payments are left on your loan?");
            _numberOfPayments = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the interest rate on your loan?");
            _interestRate = float.Parse(Console.ReadLine()) / 100;

            CalculateMonthlyPayment();
        }

    // public float CalculateAmountToPriciple()
    // {

    // }

    // public float CalculateAmountToInterest()
    // {

    // }

    public void SetPricipleAmount(float pricipleAmount)
    {
        _pricipleAmount = pricipleAmount;
    }

    public void CalculateMonthlyPayment()
    {
        float periodicInterest = _interestRate/12;
        double x = Math.Pow((1 + periodicInterest), _numberOfPayments);
        double monthlyPayment = _pricipleAmount * (((periodicInterest * x) /(x - 1)));

        SetMonthlyPayment((float) monthlyPayment);
    }

    public void SetAdditionalToPrinciple(float additionalToPrinciple)
    {

    }

    public void CalculatePayoffDate(float paymentAmount)
    {
        // The formula is -1 * log(1 - r * a / p) / log (1 + r), where p is the monthly payment,
        // r is the interest rate and a is the amount owed. The log function is the standard natural
        // logarithm, which you can compute with most scientific calculators, calculator software or
        // spreadsheet tools.

        float r = _interestRate / 12;
        float a = _pricipleAmount;
        float p = paymentAmount;
        
        double payOff = -1 * Math.Log(1 - r * a / p) / Math.Log(1 + r);

        Console.WriteLine(payOff);
    }

    public DateOnly GetPayoffDate()
    {
        return  _payOffDate;
    }

    // public override void SetMonthlyPayment(float monthlyPayment)
    // {
    //     base.SetMonthlyPayment(monthlyPayment);
    // }
    
}