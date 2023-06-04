class MortgagePayment : FixedPayment
{
    private float _interestRate, _pricipleAmount;
    private int _numberOfPayments;

    public MortgagePayment(string paymentType = "Mortgage")
        : base(paymentType)
        {            

        }

    public MortgagePayment(string paymentType, float spendingLimit, float paymentAmount, float availableFunds
        , float monthlyPayment, bool inLimit, float interestRate, float principleAmount, int numberOfPayments,
        bool isFixedPayment = true) : base(paymentType, spendingLimit, paymentAmount, availableFunds, 
        monthlyPayment, inLimit, isFixedPayment)
        {
            _interestRate = interestRate;
            _pricipleAmount = principleAmount;
            _numberOfPayments = numberOfPayments;
        }

    public void SetPricipleAmount(float pricipleAmount)
    {
        _pricipleAmount = pricipleAmount;
    }

    //This was originally a CalculateMonthlyPayment and the SetMonthlyPayment was what is now UpdateMonthlyPayment
    //This was changed to demonstrate the override aspect of Polymorphism
    public float CalculateMonthlyPayment(int years)
    {
        int numberOfPayments = years * 12;
        float periodicInterest = _interestRate/12;
        double x = Math.Pow((1 + periodicInterest), numberOfPayments);
        float monthlyPayment = (float) (_pricipleAmount * (((periodicInterest * x) /(x - 1))));

        return monthlyPayment;
    }
public override void SetInLimit()
    {
        if (_monthlyPayment < GetSpendingLimit())
        {
            _inLimit = false;
        }
    }
public override void SetMonthlyPayment()
    {
        float monthlyPayment;

        Console.WriteLine("What is your monthly mortgage payment? ");
        monthlyPayment = float.Parse(Console.ReadLine());
        Console.WriteLine("How much is left on your loan?");
        _pricipleAmount = float.Parse(Console.ReadLine());
        Console.WriteLine("How many more payments are left on your loan?");
        _numberOfPayments = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the interest rate on your loan?");
        _interestRate = float.Parse(Console.ReadLine()) / 100;

        _monthlyPayment = monthlyPayment;

        Console.WriteLine($"Your monthly payment is {monthlyPayment} and will be paid off in {_numberOfPayments/12} years.");
        Console.WriteLine("Would you like to pay a little extra to pay off your loan quicker? (yes/no)");
                                    
        string userInput = Console.ReadLine().ToLower();


            if (userInput == "yes" || userInput == "y")
            {
                userInput = "";
                
                while(userInput != "back")
                {
                    Console.WriteLine("Type '1' if you would like to set a payment based on the number of years to"
                    + " pay off your loan, or '2' to set an exact amount or type 'back' to return:");

                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        Console.WriteLine("In how many years would you like to pay off your loan?");
                        int years = int.Parse(Console.ReadLine());
                        monthlyPayment = CalculateMonthlyPayment(years);

                        Console.WriteLine($"Your new payment amount will be {monthlyPayment}. Is this okay? (yes/no)");
                        userInput = Console.ReadLine();

                        if(userInput == "yes" || userInput == "y")
                        {
                            _monthlyPayment = monthlyPayment;
                            userInput = "back";
                        }
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("What would your new monthly payment be? ");

                        monthlyPayment = float.Parse(Console.ReadLine());
                        float yearsToPayOff = CalculatePayoffDate(monthlyPayment);

                        Console.WriteLine($"You should be able to pay off your loan in {yearsToPayOff} years." 
                        + " Is this acceptable? (yes/no or type \"back\" to exit)");
                        userInput = Console.ReadLine();

                        if (userInput == "yes" || userInput == "y")
                        {
                            _monthlyPayment = monthlyPayment;
                            userInput = "back";
                        }
                    }
                }
            }
    }

    public float CalculatePayoffDate(float paymentAmount)
    {
        // The formula is -1 * log(1 - r * a / p) / log (1 + r), where p is the monthly payment,
        // r is the interest rate and a is the amount owed. The log function is the standard natural
        // logarithm, which you can compute with most scientific calculators, calculator software or
        // spreadsheet tools.

        float r = _interestRate / 12;
        float a = _pricipleAmount;
        float p = paymentAmount;
        
        double payOff = (-1 * Math.Log(1 - r * a / p) / Math.Log(1 + r))/12;
        return (float) payOff;
    }

    public float GetPrincipleAmount()
    {
        return _pricipleAmount;
    }

    public int GetNumberOfPayments()
    {
        return _numberOfPayments;
    }

    public float GetInterestRate()
    {
        return _interestRate;
    }

    // public override void SetMonthlyPayment(float monthlyPayment)
    // {
    //     base.SetMonthlyPayment(monthlyPayment);
    // }
    
}