using System;
class Program
{
    static void Main()
    {
        int suma = 0;

        // Solicitar al usuario digitar números enteros positivos
        Console.WriteLine("Ingrese digitar enteros positivos (Digite un número negativo para terminar):");

        while (true)
        {
            Console.Write("Digite un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }


            suma += numero;
        }

        Console.WriteLine($"La suma de los números ingresados es: {suma}");

    }
}