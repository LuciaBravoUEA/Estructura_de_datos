//Escribir un programa que pida al usuario una palabra y 
//muestre por pantalla el número de veces que contiene cada vocal.

// creamos la clase

public class Vocales
{
    private string palabra;

    public Vocales()
    {
        palabra = "murcielago"; // Puedes pedirla al usuario si quieres
    }

    public void MostrarResultados()
    {
        int a = 0, e = 0, i = 0, o = 0, u = 0;
        foreach (char c in palabra.ToLower())
        {
            switch (c)
            {
                case 'a': a++; break;
                case 'e': e++; break;
                case 'i': i++; break;
                case 'o': o++; break;
                case 'u': u++; break;
            }
        }
        Console.WriteLine($"Vocales en la palabra '{palabra}':");
        Console.WriteLine($"a: {a}, e: {e}, i: {i}, o: {o}, u: {u}\n");
    }
}



