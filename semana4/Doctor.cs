
//declaramos la clase para el nombre del doctor y la especialidad.
public class Doctor
{
    public string Nombre { get; set; }
    public string Especialidad { get; set; }
    // Creamos el contructor 
    public Doctor(string nombre, string especialidad)
    {
        Nombre = nombre;
        Especialidad = especialidad;
    }
    public void Mostrar()
    {
        Console.WriteLine($"Doctor:{Nombre}|Especialidad: {Especialidad}");

    }


}
