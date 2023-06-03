class Tithing : Payment
{
    private float _tithingAmount, _estimatedMontlyTithing;

    public Tithing (float income, string paymentType = "Tithing") : base (paymentType)
    {
        _estimatedMontlyTithing = CalculateTithingAmount(income);
    }

    public void SetTithingAmount(float tithing)
    {
        _tithingAmount = tithing;
    }

    public float CalculateTithingAmount(float income)
    {
        return income * 0.1f;
    }

    public override void SetMonthlyPayment()
    {
        throw new NotImplementedException();
    }
    // public override void SetMonthlyPayment(float monthlyPayment)
    // {
    //     base.SetMonthlyPayment(monthlyPayment * 0.1f);
    // }
}