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

Random random = new Random();
int numaleatorio = random.Next(1, 101);

int intentos = 0;
int inteusuario;

Console.WriteLine("Adivina el número entre 1 y 100.");

// Bucle para permitir al usuario adivinar
do
{
    Console.Write("Ingresa tu intento: ");
    inteusuario = int.Parse(Console.ReadLine());
    intentos++;

    if (inteusuario < numaleatorio)
    {
        Console.WriteLine("El número es mayor. Por favor intenta de nuevo.");
    }
    else if (inteusuario > numaleatorio)
    {
        Console.WriteLine("El número es menor. Por favor Intenta de nuevo.");
    }
    else
    {
        Console.WriteLine($"¡Felicidades! Has adivinado el número en {intentos} intentos.");
    }
} while (inteusuario != numaleatorio);
    }
}