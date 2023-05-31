class InsurancePayment : FixedPayment
{
    public float _additionalFees;

    public InsurancePayment()
        : base()
        {

        }

    public void SetAdditionalFees(float additionalFees)
    {
        _additionalFees = additionalFees;
    }

    // public override void SetMonthlyPayment(float monthlyPayment)
    // {
    //     base.SetMonthlyPayment(monthlyPayment + _additionalFees);
    // }

}