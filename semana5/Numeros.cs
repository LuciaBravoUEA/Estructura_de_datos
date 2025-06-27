using System;
using System.Collections.Generic;
// Escribir un programa que almacene en una lista los números 
// del 1 al 10 y los muestre por pantalla en orden inverso separados por comas.

public class Numeros
{
    private List<int> listaNumeros;

    public Numeros()
    {
        listaNumeros = new List<int>();
        for (int i = 1; i <= 10; i++)
            listaNumeros.Add(i);
    }

    public void MostrarResultados()
    {
        Console.WriteLine("Números del 1 al 10 en orden inverso:");
        for (int i = listaNumeros.Count - 1; i >= 0; i--)
        {
            Console.Write(listaNumeros[i]);
            if (i != 0) Console.Write(", ");
        }
        Console.WriteLine("\n");
    }
}

