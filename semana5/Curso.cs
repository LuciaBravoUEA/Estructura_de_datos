//Escribir un programa que almacene las asignaturas de
// un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua) 
//en una lista y la muestre por pantalla.


// creamos el nombre de la clase 
public class Curso
{
    private List<string> asignaturas;

    public Curso()
    {
        asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
    }

    public void MostrarResultados()
    {
        Console.WriteLine("Asignaturas del curso:");
        foreach (var a in asignaturas)
            Console.WriteLine(" - " + a);
        Console.WriteLine();
    }
}

