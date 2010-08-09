// structconversion.cs
using System;

struct RomanNumeralStruct
{
    public RomanNumeralStruct(int value)
    {
        this.value = value;
    }
    static public implicit operator RomanNumeralStruct(int value)
    {
        return new RomanNumeralStruct(value);
    }
    static public implicit operator RomanNumeralStruct(BinaryNumeral binary)
    {
        return new RomanNumeralStruct((int)binary);
    }
    static public explicit operator int(RomanNumeralStruct roman)
    {
        return roman.value;
    }
    static public implicit operator string(RomanNumeralStruct roman)
    {
        return ("Conversion not yet implemented");
    }
    private int value;
}

struct BinaryNumeral
{
    public BinaryNumeral(int value)
    {
        this.value = value;
    }
    static public implicit operator BinaryNumeral(int value)
    {
        return new BinaryNumeral(value);
    }
    static public implicit operator string(BinaryNumeral binary)
    {
        return ("Conversion not yet implemented");
    }
    static public explicit operator int(BinaryNumeral binary)
    {
        return (binary.value);
    }

    private int value;
}

struct CmpEqual
{
    int a;
    int b;

    public CmpEqual(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    static public implicit operator bool(CmpEqual value)
    {
        return value.a == value.b;
    }
}

class TestStruct
{
    static public void Main()
    {
        RomanNumeralStruct roman;
        roman = 10;
        BinaryNumeral binary;
        // Perform a conversion from a RomanNumeralStruct to a
        // BinaryNumeral:
        binary = (BinaryNumeral)(int)roman;
        // Performs a conversion from a BinaryNumeral to a RomanNumeralStruct.
        // No cast is required:
        roman = binary;
        Console.WriteLine((int)binary);
        Console.WriteLine(binary);

        CmpEqual cmp = new CmpEqual(3, 5);
        if (cmp)
            Console.WriteLine("a and b are equal");
        else
            Console.WriteLine("a and b are not equal");
    }
}
