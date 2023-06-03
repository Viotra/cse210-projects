using System;

class Program
{
    static void Main(string[] args)
    {
            Budget budget = new Budget();
            Transactions transactions = new Transactions();
            Menus menus = new Menus();
            Payment selectedPayment;
            string userInput = "", paymentType;
            float monthlyPayment;
            int i, budgetLength;

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
                                    budget.AddPayment(mortgagePayment);
                                    break;
                                case "2":
                                    FixedPayment phonePayment = new FixedPayment("Phone");
                                    budget.AddPayment(phonePayment);
                                    break;
                                case "3":
                                    FixedPayment internetPayment = new FixedPayment("Internet");
                                    budget.AddPayment(internetPayment);
                                    break;
                                case "4":
                                    FixedPayment insurancePayment = new FixedPayment("Insurance");
                                    budget.AddPayment(insurancePayment);
                                    break;
                                case "5":
                                    GroceriesPayment groceriesPayment = new GroceriesPayment();
                                    budget.AddPayment(groceriesPayment);
                                    break;
                                case "6":
                                    VariablePayment gasPayment = new VariablePayment("Gas");
                                    budget.AddPayment(gasPayment);
                                    break;
                                case "7":
                                    VariablePayment electricPayment = new VariablePayment("Electric");
                                    budget.AddPayment(electricPayment);
                                    break;
                                case "8":
                                    VariablePayment waterPayment = new VariablePayment("Water");
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
                                if (payment.GetIsFixedPayment() == false)
                                {    
                                    paymentAmount = payment.GetMonthlyPayment();
                                    paymentType = payment.GetPaymentType();
                                    Console.WriteLine($"The current amount you spend in the {paymentType} category is {paymentAmount}.");
                                    Console.WriteLine("How much would you like the spending limit for this category to be?");
                                    float spendingLimit = float.Parse(Console.ReadLine());

                                    payment.SetSpendingLimit(spendingLimit);
                                }
                                else
                                {
                                    monthlyPayment = payment.GetMonthlyPayment();
                                    payment.SetSpendingLimit(monthlyPayment);
                                    payment.SetAvailableFunds(monthlyPayment);
                                }
                            }
                        break;
                    case "2":
                    case "show budget":
                        budget.DisplayBudget();
                        break;
                    case "3":
                    case "add transaction":
                        
                        Console.WriteLine("Select which type of payment you'll be making: ");

                        menus.DisplayAllBudgetItems(budget);

                        budgetLength = budget.GetAllPayments().Count;

                        i = int.Parse(Console.ReadLine()) - 1;
                        
                        if (i == budgetLength)
                        {
                            float income = transactions.AddTransaction("Income");
                            budget.AddIncome(income);
                        }
                        else
                        {
                            selectedPayment = budget.GetAllPayments()[i];
                            paymentType = selectedPayment.GetPaymentType();
                            paymentAmount = transactions.AddTransaction(paymentType);
                            selectedPayment.SetPaymentAmount(paymentAmount);
                            selectedPayment.SetAvailableFunds(paymentAmount);
                        }
                        break;
                    case "4":
                    case "list transactions":
                        transactions.DisplayAllTransactions();
                        break;
                    case "5":
                    case "adjust budget":
                        budgetLength = budget.GetAllPayments().Count;

                        Console.WriteLine("Which item would you like to change?");
                        menus.DisplayAllBudgetItems(budget);
                        i = int.Parse(Console.ReadLine());
                        selectedPayment = budget.GetAllPayments()[i];

                        Console.WriteLine("What would you like to change in this item?");
                        menus.DisplayAdjustmentItems(selectedPayment);
                        i = int.Parse(Console.ReadLine());

                        Console.WriteLine("What would you like the new amount to be?");
                        int newAmount = int.Parse(Console.ReadLine());

                        switch (i)
                        {
                            case 1:
                                selectedPayment.SetSpendingLimit(newAmount);
                                break;
                            case 2:
                                selectedPayment.SetPaymentAmount(newAmount);
                                break;
                            case 3:
                                selectedPayment.SetAvailableFunds(newAmount);
                                break;
                        }

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