using System;
class Program
{
    static void Main()
    {
        int num1 = 1;

        while (true)
        {
            if (num1 % 7 == 0 && num1 % 11 == 0)
            {
                Console.WriteLine($"El numero entero divisible entre 7 y 11 es: {num1} ");
                break;
            }
            num1++;

        }
    }
}