class Program
{
    static void Main()
    {
        // Ejercicio 1
        Curso ejercicio1 = new Curso();
        ejercicio1.MostrarResultados();

        // Ejercicio 2
        Notas ejercicio2 = new Notas();
        ejercicio2.MostrarResultados();

        // Ejercicio 3
        Numeros ejercicio3 = new Numeros();
        ejercicio3.MostrarResultados();

        // Ejercicio 4
        Vocales ejercicio4 = new Vocales();
        ejercicio4.MostrarResultados();

        // Ejercicio 5
        Precios ejercicio5 = new Precios();
        ejercicio5.MostrarResultados();

        Console.WriteLine("Presiona cualquier tecla para finalizar...");
        Console.ReadKey();
    }
}
