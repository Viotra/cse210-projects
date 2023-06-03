class Transactions
{
    List<string> _allTransactions = new List<string>();

    public float AddTransaction(string transactionType)
    {
        DateOnly transactionDate = DateOnly.FromDateTime(DateTime.Now);
        Console.WriteLine("How munch money was spent or gained? ");
        float transactionAmount = float.Parse(Console.ReadLine());
        string transaction = $"{transactionDate} {transactionType} ${transactionAmount}";
        _allTransactions.Add(transaction);
        return transactionAmount;
    }
    public void DisplayAllTransactions()
    {
        foreach (string transaction in _allTransactions)
        {
            Console.WriteLine(transaction);
        }
        Console.ReadLine();
    }
}