using System;

public class Program
{
    public static void Main()
    {
        int baseNum = 2; // podstawa
        int exponent = 5; // wykładnik
        
        int result = Power(baseNum, exponent);
        
        Console.WriteLine($"{baseNum}^{exponent} = {result}");
    }
    
    public static int Power(int baseNum, int exponent)
    {
        int result = 1;
        
        for (int i = 1; i <= exponent; i++)
        {
            result *= baseNum;
        }
        
        return result;
    }
}
