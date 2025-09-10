//Desarrollar una aplicación en C# que permita gestionar un catálogo
// de revistas y realizar búsquedas de títulos utilizando una técnica de 
//búsqueda recursiva o iterativa.

class CatalogoRevistas
{
    static void Main()
    {
        List<string> catalogoRevistas = new List<string>
        {
            "Leonisa",
            "Azzorti",
            "Esika",
            "Vogue",
            "Sciencie",
            "AVON",
            "Yambal",
            "Cyzone",
            "Mistika",
            "Jolie"
        };

        while (true)
        {
            Console.WriteLine("\n----Catálogo de Revistas----");
            Console.WriteLine("1. Buscar título");
            Console.WriteLine("2.  Mostrar catálogo");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.Write("Ingrese el título de la revista a buscar: ");
                string titulo = Console.ReadLine();
                bool encontrado = BuscarTitulo(catalogoRevistas, titulo);
                if (encontrado)
                    Console.WriteLine("Encontrado");
                else
                    Console.WriteLine("No encontrado");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("\nCatálogo de Revistas:");
                foreach (var revista in catalogoRevistas)
                {
                    Console.WriteLine("_ " + revista);
                }
            }
            else if (opcion == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }
    // Búsqueda iterativa
    static bool BuscarTitulo(List<string> catalogo, string titulo)
    {
        foreach (var revista in catalogo)
        {
            if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }
}
