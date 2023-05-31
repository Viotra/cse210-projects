class Transactions
{
    List<Payment> _allTransactions = new List<Payment>();

    public void AddTransaction(Payment transaction)
    {
        string transactionType = transaction.GetPaymentType();
        float 
        _allTransactions.Add(transaction);
    }
    public void DisplayAllTransactions()
    {
        foreach (Payment payment in _allTransactions)
        {
            payment.DisplayTransaction();
        }
    }
}