class FuelPayment : VariablePayment
{
    public FuelPayment(string paymentType = "Fuel") : base(paymentType)
        {

        }
    //Set goal to ask how many times the user goes to fuel up in a month, then ask if they would like to set the goal to one less
    //fuel up
}