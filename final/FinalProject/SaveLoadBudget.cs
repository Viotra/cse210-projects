class SaveLoadBudget
{
    //The following information is everything I believe will be needed to save and load a budget
    // private string _paymentType;
    // private float _monthlyPayment, _percentageOfIncome, _spendingLimit, _paymentAmount, _availableFunds;
    // protected bool _isFixedPayment;
    // private bool _inLimit = true;

    public Budget LoadBudget(Budget currentBudget)
    {
        //Below is code from previous project to help establish foundation for load method

        List<Payment> allPayments = currentBudget.GetAllPayments();

        Console.WriteLine("Which file would you like to load? (Please be aware transactions will not be loaded)");
        string fileName = Console.ReadLine();

        //This block will confirm if a user would like to open a new file and delete all current entries.
        if (allPayments.Count != 0)
        {
            Console.WriteLine("Warning, opening a new file will delete all current entries. \nDo you wish to continue? (yes/no) ");
            string confirm = Console.ReadLine();
            if (confirm == "yes" || confirm == "y")
            {
                allPayments.Clear();
            }
            else
            {
                return null;
            }
        }
        
        bool firstLine = true;
        List<string> budgetFile = System.IO.File.ReadAllLines(fileName).ToList();
        Budget loadedBudget = new Budget();

        string paymentType;
        float spendingLimit, paymentAmount, availableFunds, monthlyPayment, maxPayment, interestRate,
            principleAmount; 
        int numberOfPayments, fuelUps, fuelUpGoal;
        bool inLimit, isFixedPayment;

        foreach (string line in budgetFile)
        {   
            if (firstLine == true)
            {
                string[] budgetItems = line.Split(',');
                float monthlyIncome = float.Parse(budgetItems[0]);
                float leftOverFunds = float.Parse(budgetItems[1]);
                float currentIncome = float.Parse(budgetItems[2]);
                bool isTithePayer = Boolean.Parse(budgetItems[3]);

                loadedBudget = new Budget(monthlyIncome, leftOverFunds, currentIncome, isTithePayer);

                firstLine = false;
                continue;
            }
           
            string[] paymentItems = line.Split(",");
            paymentType = paymentItems[0];

            switch (paymentType)
            {
                case "Phone":
                case "Internet":
                case "Insurance":
                    spendingLimit = float.Parse(paymentItems[1]);
                    paymentAmount = float.Parse(paymentItems[2]);
                    availableFunds = float.Parse(paymentItems[3]);
                    monthlyPayment = float.Parse(paymentItems[4]);
                    inLimit = Boolean.Parse(paymentItems[5]);
                    isFixedPayment = Boolean.Parse(paymentItems[6]);
                    FixedPayment fiPayment = new FixedPayment(paymentType, spendingLimit,
                        paymentAmount, availableFunds , monthlyPayment, inLimit, isFixedPayment);
                    loadedBudget.AddPayment(fiPayment);
                    break;
                case "Gas":
                case "Water":
                case "Electric":
                    spendingLimit = float.Parse(paymentItems[1]);
                    paymentAmount = float.Parse(paymentItems[2]);
                    availableFunds = float.Parse(paymentItems[3]);
                    monthlyPayment = float.Parse(paymentItems[4]);
                    inLimit = Boolean.Parse(paymentItems[5]);
                    isFixedPayment = Boolean.Parse(paymentItems[7]);
                    maxPayment = float.Parse(paymentItems[6]);
                    VariablePayment vPayment = new VariablePayment(paymentType, spendingLimit,
                        paymentAmount, availableFunds , monthlyPayment, inLimit, maxPayment, 
                        isFixedPayment);
                    loadedBudget.AddPayment(vPayment);
                    break;
                case "Mortgage":
                    spendingLimit = float.Parse(paymentItems[1]);
                    paymentAmount = float.Parse(paymentItems[2]);
                    availableFunds = float.Parse(paymentItems[3]);
                    monthlyPayment = float.Parse(paymentItems[4]);
                    inLimit = Boolean.Parse(paymentItems[5]);
                    isFixedPayment = Boolean.Parse(paymentItems[9]);
                    interestRate = float.Parse(paymentItems[6]);
                    principleAmount = float.Parse(paymentItems[7]);
                    numberOfPayments = int.Parse(paymentItems[8]);
                    MortgagePayment mPayment = new MortgagePayment(paymentType, spendingLimit,
                        paymentAmount, availableFunds , monthlyPayment, inLimit, interestRate,
                        principleAmount, numberOfPayments, isFixedPayment);
                    loadedBudget.AddPayment(mPayment);
                    break;
                case "Groceries":
                    spendingLimit = float.Parse(paymentItems[1]);
                    paymentAmount = float.Parse(paymentItems[2]);
                    availableFunds = float.Parse(paymentItems[3]);
                    monthlyPayment = float.Parse(paymentItems[4]);
                    inLimit = Boolean.Parse(paymentItems[5]);
                    isFixedPayment = Boolean.Parse(paymentItems[7]);
                    maxPayment = float.Parse(paymentItems[6]);
                    GroceriesPayment gPayment = new GroceriesPayment(paymentType, spendingLimit,
                        paymentAmount, availableFunds , monthlyPayment, inLimit, maxPayment, 
                        isFixedPayment);
                    loadedBudget.AddPayment(gPayment);
                    break;
                case "Fuel":
                    spendingLimit = float.Parse(paymentItems[1]);
                    paymentAmount = float.Parse(paymentItems[2]);
                    availableFunds = float.Parse(paymentItems[3]);
                    monthlyPayment = float.Parse(paymentItems[4]);
                    inLimit = Boolean.Parse(paymentItems[5]);
                    isFixedPayment = Boolean.Parse(paymentItems[9]);
                    maxPayment = float.Parse(paymentItems[6]);
                    fuelUps = int.Parse(paymentItems[7]);
                    fuelUpGoal = int.Parse(paymentItems[8]);
                    FuelPayment fPayment = new FuelPayment(paymentType, spendingLimit,
                        paymentAmount, availableFunds , monthlyPayment, inLimit, maxPayment,
                        fuelUps, fuelUpGoal, isFixedPayment);
                    loadedBudget.AddPayment(fPayment);                   
                    break;
                case "Entertainment":
                    spendingLimit = float.Parse(paymentItems[1]);
                    paymentAmount = float.Parse(paymentItems[2]);
                    availableFunds = float.Parse(paymentItems[3]);
                    monthlyPayment = float.Parse(paymentItems[4]);
                    inLimit = Boolean.Parse(paymentItems[5]);
                    isFixedPayment = Boolean.Parse(paymentItems[7]);
                    maxPayment = float.Parse(paymentItems[6]);
                    GroceriesPayment ePayment = new GroceriesPayment(paymentType, spendingLimit,
                        paymentAmount, availableFunds , monthlyPayment, inLimit, maxPayment, 
                        isFixedPayment);
                    loadedBudget.AddPayment(ePayment);
                    break;
                case "Tithing":
                        monthlyPayment = float.Parse(paymentItems[1]);
                        paymentAmount = float.Parse(paymentItems[2]);
                        Tithing tPayment = new Tithing(paymentType, monthlyPayment, paymentAmount);
                        loadedBudget.AddPayment(tPayment);
                        break;
            }
        }
        return loadedBudget;
    }

    public void SaveBudget(Budget budget)
    {
        Console.WriteLine("What would you like to name your file? ");
        string fileName = Console.ReadLine();

        //This block will confirm with user if they wish to overwrite an already existing save file.
        if (File.Exists(fileName))
        {
            Console.Write($"{fileName} already exists. \nWould you like to overwrite saved file? (yes/no) ");
            string confirm = Console.ReadLine();

            if (confirm == "yes" || confirm == "y")
            {
                
            }
            else
            {
                return;
            }
        }

        using (StreamWriter saveFile = new StreamWriter (fileName))
        {
            List<Payment> allPayments = budget.GetAllPayments();
            float monthlyIncome = budget.GetMonthlyIncome();
            float leftOverFunds = budget.GetLeftOverFunds();
            float currentIncome = budget.GetCurrentIncome();
            bool isTithePayer = budget.GetIsTithePayer();

            string paymentType, paymentItems;
            float spendingLimit, paymentAmount, availableFunds, monthlyPayment, maxPayment, interestRate,
                principleAmount; 
            int numberOfPayments, fuelUps, fuelUpGoal;
            bool inLimit, isFixedPayment;

            string budgetInfo = string.Format("{0},{1},{2},{3},", monthlyIncome, leftOverFunds, currentIncome, isTithePayer);
            saveFile.WriteLine(budgetInfo);
            foreach (Payment payment in allPayments)
            {
                paymentType = payment.GetPaymentType();

                switch (paymentType)
                {
                    case "Phone":
                    case "Internet":
                    case "Insurance":
                        spendingLimit = payment.GetSpendingLimit();
                        paymentAmount = payment.GetPaymentAmount();
                        availableFunds = payment.GetAvailableFunds();
                        monthlyPayment = payment.GetMonthlyPayment();
                        inLimit = payment.GetInLimit();
                        isFixedPayment = payment.GetIsFixedPayment();
                        paymentItems = string.Format("{0},{1},{2},{3},{4},{5},{6}", paymentType, spendingLimit,
                            paymentAmount, availableFunds , monthlyPayment, inLimit, isFixedPayment);
                        saveFile.WriteLine(paymentItems);
                        break;
                    case "Gas":
                    case "Water":
                    case "Electric":
                        spendingLimit = payment.GetSpendingLimit();
                        paymentAmount = payment.GetPaymentAmount();
                        availableFunds = payment.GetAvailableFunds();
                        monthlyPayment = payment.GetMonthlyPayment();
                        inLimit = payment.GetInLimit();
                        isFixedPayment = payment.GetIsFixedPayment();
                        VariablePayment vPayment = (VariablePayment) payment;
                        maxPayment = vPayment.GetMaxPayment();
                        paymentItems = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", paymentType, spendingLimit,
                            paymentAmount, availableFunds , monthlyPayment, inLimit, maxPayment, isFixedPayment);
                        saveFile.WriteLine(paymentItems);
                        break;
                    case "Mortgage":
                        spendingLimit = payment.GetSpendingLimit();
                        paymentAmount = payment.GetPaymentAmount();
                        availableFunds = payment.GetAvailableFunds();
                        monthlyPayment = payment.GetMonthlyPayment();
                        inLimit = payment.GetInLimit();
                        isFixedPayment = payment.GetIsFixedPayment();
                        MortgagePayment mPayment = (MortgagePayment) payment;
                        interestRate = mPayment.GetInterestRate();
                        principleAmount = mPayment.GetPrincipleAmount();
                        numberOfPayments = mPayment.GetNumberOfPayments();
                        paymentItems = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},(9)", paymentType, spendingLimit,
                            paymentAmount, availableFunds , monthlyPayment, inLimit, interestRate, principleAmount, 
                            numberOfPayments, isFixedPayment);
                        saveFile.WriteLine(paymentItems);
                        break;
                    case "Groceries":
                        spendingLimit = payment.GetSpendingLimit();
                        paymentAmount = payment.GetPaymentAmount();
                        availableFunds = payment.GetAvailableFunds();
                        monthlyPayment = payment.GetMonthlyPayment();
                        inLimit = payment.GetInLimit();
                        isFixedPayment = payment.GetIsFixedPayment();
                        GroceriesPayment gPayment = (GroceriesPayment) payment;
                        maxPayment = gPayment.GetMaxPayment();
                        paymentItems = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", paymentType, spendingLimit,
                            paymentAmount, availableFunds , monthlyPayment, inLimit, maxPayment, isFixedPayment);
                        saveFile.WriteLine(paymentItems);
                        break;
                    case "Fuel":
                        spendingLimit = payment.GetSpendingLimit();
                        paymentAmount = payment.GetPaymentAmount();
                        availableFunds = payment.GetAvailableFunds();
                        monthlyPayment = payment.GetMonthlyPayment();
                        inLimit = payment.GetInLimit();
                        isFixedPayment = payment.GetIsFixedPayment();
                        FuelPayment fPayment = (FuelPayment) payment;
                        maxPayment = fPayment.GetMaxPayment();
                        fuelUps = fPayment.GetFuelUps();
                        fuelUpGoal = fPayment.GetFuelUpGoal();
                        paymentItems = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", paymentType, spendingLimit,
                            paymentAmount, availableFunds , monthlyPayment, inLimit, maxPayment, fuelUps, fuelUpGoal, isFixedPayment);
                        saveFile.WriteLine(paymentItems);
                        break;
                    case "Entertainment":
                        spendingLimit = payment.GetSpendingLimit();
                        paymentAmount = payment.GetPaymentAmount();
                        availableFunds = payment.GetAvailableFunds();
                        monthlyPayment = payment.GetMonthlyPayment();
                        inLimit = payment.GetInLimit();
                        isFixedPayment = payment.GetIsFixedPayment();
                        EntertainmentPayment ePayment = (EntertainmentPayment) payment;
                        maxPayment = ePayment.GetMaxPayment();
                        paymentItems = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", paymentType, spendingLimit,
                            paymentAmount, availableFunds , monthlyPayment, inLimit, maxPayment, isFixedPayment);
                        saveFile.WriteLine(paymentItems);
                        break;
                    case "Tithing":
                        monthlyPayment = payment.GetMonthlyPayment();
                        paymentAmount = payment.GetPaymentAmount();
                        paymentItems = string.Format("{0},{1},{2}", paymentType, monthlyPayment, paymentAmount);
                        break;
                }

            }
        }
    }
}