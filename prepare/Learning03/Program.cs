using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();

        string fractionString1 = fraction1.GetFractionString();
        Console.WriteLine(fractionString1);

        string decimalValue1 = fraction1.GetDecimalValue().ToString();
        Console.WriteLine(decimalValue1);

        Fraction fraction2 = new Fraction(6);

        string fractionString2 = fraction2.GetFractionString();
        Console.WriteLine(fractionString2);

        string decimalValue2 = fraction2.GetDecimalValue().ToString();
        Console.WriteLine(decimalValue2);

        Fraction fraction3 = new Fraction(6,7);

        string fractionString3 = fraction3.GetFractionString();
        Console.WriteLine(fractionString3);

        string decimalValue3 = fraction3.GetDecimalValue().ToString();
        Console.WriteLine(decimalValue3);
    
        Fraction fraction4 = new Fraction (3,4);

        string fractionString4 = fraction4.GetFractionString();
        Console.WriteLine(fractionString4);

        string decimalValue4 = fraction4.GetDecimalValue().ToString();
        Console.WriteLine(decimalValue4);

        Fraction fraction5 = new Fraction (1,3);

        string fractionString5 = fraction5.GetFractionString();
        Console.WriteLine(fractionString5);

        string decimalValue5 = fraction5.GetDecimalValue().ToString();
        Console.WriteLine(decimalValue5);

        // double test = 3.0/4.0;
        // string sTest = test.ToString();
        // Console.WriteLine(sTest);

    }
}