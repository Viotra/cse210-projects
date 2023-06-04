class FuelPayment : VariablePayment
{
    int _fuelUps, _fuelUpGoal;
    public FuelPayment(string paymentType = "Fuel") : base(paymentType)
        {
            Console.WriteLine("How many times a month do you fuel up?");
            Console.ReadLine();
            Console.WriteLine("Would it be possible to lower vehicle usage and limit the number"
            + " of fuel ups? (yes/no)");
            string userInput = Console.ReadLine();

            if (userInput == "yes" || userInput == "y")
            {
                Console.WriteLine("How many fuel ups would you like to aim for?");
                _fuelUpGoal = int.Parse(Console.ReadLine());
                Console.WriteLine($"Your goal has been set to {_fuelUpGoal} fuel ups.");
            }
        }
    public FuelPayment(string paymentType, float spendingLimit, float paymentAmount, float availableFunds
        , float monthlyPayment, bool inLimit, float maxPayment, int fuelUps, int fuelUpGoal, bool isFixedPayment
         = false) : base(paymentType, spendingLimit, paymentAmount, availableFunds, monthlyPayment, inLimit, 
         maxPayment, isFixedPayment)
        {
            _fuelUpGoal = fuelUpGoal;
            _fuelUps = fuelUps;
        }

    public int GetFuelUpGoal()
    {
        return _fuelUpGoal;
    }

    public void SetFuelUpGoal(int fuelUpGoal)
    {
        _fuelUpGoal = fuelUpGoal;
    }

    public int GetFuelUps()
    {
        return _fuelUps;
    }

    public void SetFuelUps(int fuelUps)
    {
        _fuelUps = fuelUps;
    }

    public void AddFuelUp()
    {
        _fuelUps++;
    }

     public override void SetPaymentAmount(float paymentAmount)
    {
        base.SetPaymentAmount(paymentAmount);
        Console.WriteLine("Was there any extra car usage which could have been avoided? (yes/no)");
        string userInput = Console.ReadLine();
        if (userInput == "yes" || userInput == "y")
        {
            Console.WriteLine("How much money would you estimate could have been saved?");
            float unnecessarySpending = float.Parse(Console.ReadLine());
            AddUnnecessaryPayment(unnecessarySpending);
        }
        AddFuelUp();
    }
}