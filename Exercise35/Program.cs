﻿namespace Exercise35;

public class Exercise35 {
    static void Main(string[] args) {
        Console.Write("Input a first number(<100): ");

        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input a second number(>200): ");

        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((m < 100 && n > 200));
    }
}