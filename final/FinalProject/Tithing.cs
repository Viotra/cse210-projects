class Tithing
{
    private bool _isPaid;
    private float _tithingAmount;

    public Tithing(float income)
        {
            _tithingAmount = income * 0.10f;
        }
    public void SetIsPaid(bool isPaid)
    {
        _isPaid = isPaid;
    }

    // public override void SetMonthlyPayment(float monthlyPayment)
    // {
    //     base.SetMonthlyPayment(monthlyPayment * 0.1f);
    // }
}