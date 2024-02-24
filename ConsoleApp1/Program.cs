using System;
class Program
{
    static void Main()
    {
        int Num = 0, Mayor = 0;

        do
        {
            Console.WriteLine("Ingrese Numero");
            Num = TryParse(readLine(), out Num);

            if (Num > Mayor)
            {
                Mayor = Num;
            }
        }
        while (Num != 0);
    }
}