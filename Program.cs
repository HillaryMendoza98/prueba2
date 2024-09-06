

// Verificar si un Número es Par o Impar

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} es un número par.");
        }
        else
        {
            Console.WriteLine($"{numero} es un número impar.");
        }
    }
}
