class Tithing : Payment
{
    private float _monthlyTithing;

    public Tithing(float income, string paymentType = "Tithing") : base(paymentType)
    {
        _monthlyTithing = CalculateTithingAmount(income);

        Console.WriteLine($"Is ${_monthlyTithing} the correct monthly tithing payment? (yes/no)");
        string userInput = Console.ReadLine();

        if (userInput == "no" || userInput == "n")
        {
            Console.WriteLine("How much do you pay each month in tithing? ");
            _monthlyTithing = float.Parse(Console.ReadLine());
        }

        SetMonthlyPayment();
    }

    public Tithing(string paymentType, float monthlyPayment, float paymentAmount) : base(paymentType, monthlyPayment, paymentAmount)
    {

    }
    public float CalculateTithingAmount(float income)
    {
        return income * 0.1f;
    }

    public override void SetMonthlyPayment()
    {
        _monthlyPayment = _monthlyTithing;
    }
    // public override void SetMonthlyPayment(float monthlyPayment)
    // {
    //     base.SetMonthlyPayment(monthlyPayment * 0.1f);
    // }
}