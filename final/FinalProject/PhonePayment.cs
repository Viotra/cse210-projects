class PhonePayment : FixedPayment
{
    private float _additionalFees;

    public PhonePayment()
        : base()
        {

        }
    public void SetAdditionalFees()
    {
        Console.WriteLine("How much are the additional fees? ");
        float additionalFees = float.Parse(Console.ReadLine());
        _additionalFees = additionalFees;
    }

    // public override void SetMonthlyPayment(float monthlyPayment)
    // {
    //     base.SetMonthlyPayment(monthlyPayment + _additionalFees);
    // }
}
