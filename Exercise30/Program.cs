﻿namespace Exercise30;

public class Exercise30 {
    public static void Main() {
        string hexval = "4B0";

        Console.WriteLine("Hexadecimal number: " + hexval);

        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

        Console.WriteLine("Convert to-");

        Console.WriteLine("Decimal number: " + decValue);
    }
}