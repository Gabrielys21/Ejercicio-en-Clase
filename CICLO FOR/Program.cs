using System;
class Program
{
    static void Main()
    {
        for (int H = 1; H < 24; H++)
        {
            for (int M = 1; M < 60;  M++)
            {
                for(int S = 1; S < 60; S++)
                {
                    Console.SetCursorPosition(10,10);
                    Console.WriteLine($"{H}:{M}:{S}");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}