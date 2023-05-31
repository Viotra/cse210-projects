using System;

class Program
{
    static void Main(string[] args)
    {
            Budget budget = new Budget();
            Transactions transactions = new Transactions();
            Menus menus = new Menus();
            string userInput = "";

            while (userInput != "7" && userInput != "quit")
            {
                menus.DisplayMainMenu();
                userInput = Console.ReadLine().ToLower();

                switch(userInput)
                {
                    case "1":
                    case "create new budget":
                        string userInput2 = "";
                        while (userInput2 != "13" && userInput != "quit")
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
                                    float payment = float.Parse(Console.ReadLine());
                                    mortgagePayment.CalculatePayoffDate(payment);
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
                            }
                            budget.CalculatePercentageOfIncome();
                        }
                        break;
                    case "2":
                    case "add transaction":
                        break;
                    case "3":
                    case "list transactions":
                        break;
                    case "4":
                    case "adjust budget":
                        break;
                    case "5":
                    case "save budget":
                        break;
                    case "6":
                    case "load budget":
                        break;
                }
            }
    }
}