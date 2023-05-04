using System;

public class Fraction{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
       _numerator = 1;
       _denominator = 1;
    }

    public Fraction (int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void SetNumerator()
    {
        Console.Write("Set a new numerator: ");
        int numerator = int.Parse(Console.ReadLine());
        _numerator = numerator;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetDenominator()
    {
        Console.Write("Set a new denominator: ");
        int denominator = int.Parse(Console.ReadLine());
        _denominator = denominator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_numerator}/{_denominator}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double) _numerator / (double) _denominator;
        return decimalValue;
    }
}