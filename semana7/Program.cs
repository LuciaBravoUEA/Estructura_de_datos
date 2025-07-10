using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el ejercicio:");
        Console.WriteLine("1. Balanceo de paréntesis");
        Console.WriteLine("2. Torres de Hanoi");
        Console.Write("Opción: ");
        string? opcion = Console.ReadLine();

        if (opcion == null)
        {
            Console.WriteLine("No se ingrso ninguna opción.");
            return;
        }
        switch (opcion)
        {
            case "1":
                Balanceo.Ejecutar();
                break;
            case "2":
                Hanoi.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
