using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Int32.Parse(Console.ReadLine());

        if (a < 0 && b < 0 && c < 0) Console.WriteLine("-");
        else if (a >= 0 && b >= 0 && c >= 0) Console.WriteLine("+");
        else if (a < 0 && b < 0 && c >= 0) Console.WriteLine("+");
        else if (a < 0 && b >= 0 && c < 0) Console.WriteLine("+");
        else if (a >= 0 && b < 0 && c < 0) Console.WriteLine("+");
        else if (a < 0 && b >= 0 && c >= 0) Console.WriteLine("-");
        else if (a >= 0 && b < 0 && c >= 0) Console.WriteLine("-");
        else if (a >= 0 && b >= 0 && c < 0) Console.WriteLine("-");
    }
}

