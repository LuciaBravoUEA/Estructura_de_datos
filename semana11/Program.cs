// Desarrollar una aplicación en C# que funcione como un traductor básico
// entre los idiomas inglés y español, utilizando diccionarios como 
// estructura principal para almacenar las palabras y sus equivalencias

class DiccionarioTraductor
{
    static void Main(string[] args)
    {
        // Crear un diccionario para almacenar las palabras y sus equivalencias
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"tiempo", "time"},
            {"persona", "person"},
            {"año", "year"},
            {"día", "day"},
            {"hombre", "man"},
            {"mundo", "world"},
            {"vida", "life"},
            {"niño", "child"},
            {"ojo", "eye"},
            {"trabajo", "work"}
        };

        int opcion;
        do
        {
            Console.WriteLine("\n=========== MENÚ ===========");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("\nIngrese la frase en español: ");
                    string frase = Console.ReadLine();

                    // Separar las palabras 
                    string[] palabras = frase.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine("\nTraducción:");
                    foreach (string palabra in palabras)
                    {
                        string limpia = palabra.ToLower();
                        if (diccionario.ContainsKey(limpia))
                        {
                            Console.Write(diccionario[limpia] + " ");
                        }
                        else
                        {
                            Console.Write(palabra + " "); // Si no está en el diccionario, se deja igual
                        }
                    }
                    Console.WriteLine("\n");
                    break;

                case 2:
                    Console.Write("\nIngrese la palabra en español: ");
                    string palabraEspañol = Console.ReadLine().ToLower();

                    Console.Write("Ingrese la traducción en inglés: ");
                    string palabraIngles = Console.ReadLine().ToLower();

                    if (!diccionario.ContainsKey(palabraEspañol))
                    {
                        diccionario.Add(palabraEspañol, palabraIngles);
                        Console.WriteLine($" Palabra '{palabraEspañol}' agregada con la traducción '{palabraIngles}'.");
                    }
                    else
                    {
                        Console.WriteLine(" La palabra ya existe en el diccionario.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\n Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 3);

        Console.WriteLine("\nGracias por usar el traductor. ¡Hasta luego!");
    }
}
