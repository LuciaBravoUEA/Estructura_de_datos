

//Creación de registro de un estudiante.

using System;
namespace RegistroEstudiante
{
    // Declaramos la clase Estudiante
    class Estudiantes
    {
        // Propiedades públicas con set y get
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dirección { get; set; }
        public string[] Teléfonos { get; set; }

        // Constructor de la clase
        public Estudiantes(int id, string nombres, string apellidos, string dirección, string[] teléfonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Dirección = dirección;
            Teléfonos = teléfonos;
        }

        // Método para mostrar los datos del estudiante
        public void MostrarDatosdelEstudiante()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Dirección);
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Teléfonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Teléfonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el array de los teléfonos
            string[] Telefonos = new string[3];
            Telefonos[0] = "0985462143";
            Telefonos[1] = "0985471231";
            Telefonos[2] = "0952315623";

            // Creamos el objeto estudiante
            Estudiantes estudiante = new Estudiantes(
                21456589,
                "Lucía",
                "Bravo",
                "Santo Domingo AV. El Proletariado",
                Telefonos
            );

            // Mostrar datos del estudiante
            estudiante.MostrarDatosdelEstudiante();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey(); 
        }
    }
}
