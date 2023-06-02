using System;

class Program
{
    static void Main(string[] args)
    {
            Budget budget = new Budget();
            Transactions transactions = new Transactions();
            Menus menus = new Menus();
            string userInput = "";

            while (userInput != "8" && userInput != "quit")
            {
                menus.DisplayMainMenu();
                userInput = Console.ReadLine().ToLower();
                float paymentAmount;

                switch(userInput)
                {
                    case "1":
                    case "create new budget":
                        string userInput2 = "";
                        while (userInput2 != "back")
                        {
                            menus.DisplayCreateBudgetMenu();
                            userInput2 = Console.ReadLine();

                            switch (userInput2)
                            {
                                case "1":
                                    MortgagePayment mortgagePayment = new MortgagePayment();
                                    Console.WriteLine(mortgagePayment.GetMonthlyPayment());
                                    Console.ReadLine();
                                    Console.WriteLine("Enter the amount you wish to pay each month:");
                                    paymentAmount = float.Parse(Console.ReadLine());
                                    mortgagePayment.CalculatePayoffDate(paymentAmount);
                                    Console.ReadLine();
                                    budget.AddPayment(mortgagePayment);
                                    break;
                                case "2":
                                    PhonePayment phonePayment = new PhonePayment();
                                    budget.AddPayment(phonePayment);
                                    break;
                                case "3":
                                    InternetPayment internetPayment = new InternetPayment();
                                    budget.AddPayment(internetPayment);
                                    break;
                                case "4":
                                    InsurancePayment insurancePayment = new InsurancePayment();
                                    budget.AddPayment(insurancePayment);
                                    break;
                                case "5":
                                    GroceriesPayment groceriesPayment = new GroceriesPayment();
                                    budget.AddPayment(groceriesPayment);
                                    break;
                                case "6":
                                    GasPayment gasPayment = new GasPayment();
                                    budget.AddPayment(gasPayment);
                                    break;
                                case "7":
                                    ElectricPayment electricPayment = new ElectricPayment();
                                    budget.AddPayment(electricPayment);
                                    break;
                                case "8":
                                    WaterPayment waterPayment = new WaterPayment();
                                    budget.AddPayment(waterPayment);
                                    break;
                                case "9":
                                    FuelPayment fuelPayment = new FuelPayment();
                                    budget.AddPayment(fuelPayment);
                                    break;
                                case "10":
                                    EntertainmentPayment entertainmentPayment = new EntertainmentPayment();
                                    budget.AddPayment(entertainmentPayment);
                                    break;
                                case "11":
                                    budget.SetMonthlyIncome();
                                    break;
                                case "12":
                                    break;
                            }
                        }
                        budget.CalculatePercentageOfIncome();

                            foreach (Payment payment in budget.GetAllPayments())
                            {
                                paymentAmount = payment.GetMonthlyPayment();
                                string paymentType = payment.GetPaymentType();
                                Console.WriteLine($"The current amount you spend in the {paymentType} category is {paymentAmount}.");
                                Console.WriteLine("How much would you like to limit this category to?");
                                float spendingLimit = float.Parse(Console.ReadLine());

                                payment.SetSpendingLimit(spendingLimit);
                            }
                        break;
                    case "2":
                    case "show budget":
                        budget.DisplayBudget();
                        break;
                    case "3":
                    case "add transaction":
                        List<Payment> allPayments = budget.GetAllPayments();
                        int i;
                        string transactionType;

                        Console.WriteLine("Select which type of payment you'll be making: ");

                        int budgetLength = allPayments.Count;
                        for (i = 0; i < budgetLength; i++)
                        {  
                            transactionType = allPayments[i].GetPaymentType();    
                            Console.WriteLine($"{i + 1}. {transactionType}");                                                  
                        }
                        Console.WriteLine($"{budgetLength + 1}. Income");

                        i = int.Parse(Console.ReadLine()) - 1;
                        
                        if (i == budgetLength)
                        {
                            float income = transactions.AddTransaction("Income");
                            budget.AddIncome(income);
                        }
                        else
                        {
                            Payment payment = allPayments[i];
                            transactionType = payment.GetPaymentType();
                            paymentAmount = transactions.AddTransaction(transactionType);
                            payment.ReduceSpendingLimit(paymentAmount);
                        }
                        break;
                    case "4":
                    case "list transactions":
                        transactions.DisplayAllTransactions();
                        break;
                    case "5":
                    case "adjust budget":
                        break;
                    case "6":
                    case "save budget":
                        break;
                    case "7":
                    case "load budget":
                        break;
                }
            }
    }
}