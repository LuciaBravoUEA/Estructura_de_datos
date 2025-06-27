//Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua) 
//en una lista, pregunte al usuario la nota que ha sacado en cada asignatura, y después las muestre por pantalla con 
//el mensaje En <asignatura> has sacado <nota> donde ha sacado en cada asignatura, y después las muestre por pantalla 
//con el mensaje En <asignatura> has sacado <nota> donde.

//Creamos la Clase

class Asignatura
{
    public string Nombres { get; set; }
    public double Nota { get; set; }

    public Asignatura(string nombres)
    {
        Nombres = nombres;
    }
}

class Notas
{
    private List<Asignatura> asignaturas;

    public Notas()
    {
        asignaturas = new List<Asignatura>
        {
            new Asignatura("Matemáticas"),
            new Asignatura("Física"),
            new Asignatura("Química"),
            new Asignatura("Historia"),
            new Asignatura("Lengua")
        };
    }

    public void MostrarResultados()
    {
        // Pedimos las notas
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.Write("Ingresa la nota de " + asignaturas[i].Nombres + ": ");
            string entrada = Console.ReadLine();

            double nota;
            if (double.TryParse(entrada, out nota))
            {
                asignaturas[i].Nota = nota;
            }
            else
            {
                Console.WriteLine("Entrada inválida, la nota será 0.");
                asignaturas[i].Nota = 0;
            }
        }

        // Mostramos los resultados
        Console.WriteLine("\nRESULTADOS:");
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine("En " + asignaturas[i].Nombres + " tu nota es " + asignaturas[i].Nota);
        }
        Console.WriteLine();
    }
}
