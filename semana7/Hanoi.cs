// Resolución del problema de las Torres de Hanoi
//Desarrolle un algoritmo que resuelva el problema de 
//las Torres de Hanoi utilizando pilas. El programa 
//debe mostrar paso a paso cómo se mueven los discos 
//entre las torres.

public class Hanoi
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese el número de discos:");
        string? entrada = Console.ReadLine();
        if (string.IsNullOrEmpty(entrada))
        {
            Console.WriteLine("No se ingresó ningún número.");
            return;
        }
        int n = int.Parse(entrada);
        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();
        for (int i = n; i >= 1; i--)
            torreA.Push(i);
        MostrarTorres(torreA, torreB, torreC, "A", "B", "C");
        MoverDiscos(n, torreA, torreC, torreB, "A", "C", "B");
    }

    static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string origenNombre, string destinoNombre, string auxiliarNombre)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {origenNombre} a {destinoNombre}");
            MostrarTorres(origen, auxiliar, destino, origenNombre, auxiliarNombre, destinoNombre);
        }
        else
        {
            MoverDiscos(n - 1, origen, auxiliar, destino, origenNombre, auxiliarNombre, destinoNombre);
            MoverDiscos(1, origen, destino, auxiliar, origenNombre, destinoNombre, auxiliarNombre);
            MoverDiscos(n - 1, auxiliar, destino, origen, auxiliarNombre, destinoNombre, origenNombre);
        }
    }

    static void MostrarTorres(Stack<int> torreA, Stack<int> torreB, Stack<int> torreC, string nombreA, string nombreB, string nombreC)
    {
        Console.WriteLine("Estado actual de las torres:");
        ImprimirTorre(torreA, nombreA);
        ImprimirTorre(torreB, nombreB);
        ImprimirTorre(torreC, nombreC);
        Console.WriteLine("-----------------------------------");
    }

    static void ImprimirTorre(Stack<int> torre, string nombre)
    {
        Console.Write($"{nombre}: ");
        foreach (var disco in torre)
        {
            Console.Write(disco + " ");
        }
        Console.WriteLine();
    }
}