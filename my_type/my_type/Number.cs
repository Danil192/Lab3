using System;

public class Number
{
    private long value;  // Внутреннее представление числа в десятичной форме

    public static bool IsValidNumber(string input, int baseOfSystem)
    {
        try
        {
            Convert.ToInt64(input, baseOfSystem);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public Number(string input, int baseOfSystem)
    {
        this.value = Convert.ToInt64(input, baseOfSystem);
    }

    public static Number operator +(Number a, Number b)
    {
        return new Number((a.value + b.value).ToString(), 10);
    }

    public static Number operator -(Number a, Number b)
    {
        return new Number((a.value - b.value).ToString(), 10);
    }

    public static Number operator *(Number a, Number b)
    {
        return new Number((a.value * b.value).ToString(), 10);
    }

    public static bool operator ==(Number a, Number b)
    {
        return a.value == b.value;
    }

    public static bool operator !=(Number a, Number b)
    {
        return a.value != b.value;
    }

    public override bool Equals(object obj)
    {
        Number num = obj as Number;
        if (num == null) return false;
        return this.value == num.value;
    }

    public string ToString(int baseOfSystem)
    {
        return Convert.ToString(value, baseOfSystem);
    }
}
