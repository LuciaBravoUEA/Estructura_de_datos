//Escribir un programa que almacene en una lista
// los siguientes precios, 50, 75, 46, 22, 80, 65, 8, y muestre
// por pantalla el menor y el mayor de los precios.
using System;
using System.Collections.Generic;

class Precios
{
    private List<int> listaPrecios;

    public Precios()
    {
        // Inicializamos la lista con los precios dados
        listaPrecios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };
    }

    public int ObtenerMayor()
    {
        int mayor = listaPrecios[0];
        foreach (int precio in listaPrecios)
        {
            if (precio > mayor)
            {
                mayor = precio;
            }
        }
        return mayor;
    }

    public int ObtenerMenor()
    {
        int menor = listaPrecios[0];
        foreach (int precio in listaPrecios)
        {
            if (precio < menor)
            {
                menor = precio;
            }
        }
        return menor;
    }

    public void MostrarResultados()
    {
        Console.WriteLine("El precio mayor es: " + ObtenerMayor());
        Console.WriteLine("El precio menor es: " + ObtenerMenor());
    }
}

