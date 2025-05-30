using System;

class StringStats
{
    static void Main()
    {
        Console.Write("Въведете текст: ");
        string input = Console.ReadLine();

        int letters = 0, digits = 0, spaces = 0;
        foreach (char c in input)
        {
            if (char.IsLetter(c)) letters++;
            else if (char.IsDigit(c)) digits++;
            else if (char.IsWhiteSpace(c)) spaces++;
        }

        Console.WriteLine($"\nБукви: {letters}\nЦифри: {digits}\nИнтервали: {spaces}");
    }
}