using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Power(2, 3));  
        Console.WriteLine(Power(5, 2));  
        Console.WriteLine(Power(3, 4));  
        Console.WriteLine(Power(2, 0));  
        Console.WriteLine(Power(4, -2)); 
    }

    static double Power(double baseNumber, int exponent)
    {
        if (exponent == 0)
            return 1;

        bool isNegativeExponent = exponent < 0;

        int absExponent = Math.Abs(exponent);

        double result = 1;

        for (int i = 0; i < absExponent; i++)
        {
            result *= baseNumber;
        }

        if (isNegativeExponent)
            result = 1 / result;
        
        return result;
    }
}
