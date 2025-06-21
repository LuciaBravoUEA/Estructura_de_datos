//declaramos la clase Paciente

public class Paciente
{
    public string Cedula { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
// Creamos el contructor 
    public Paciente(string cedula, string nombre, string apellido, string email, string telefono)
    {
        Cedula = cedula;
        Nombres = nombre;
        Apellidos = apellido;
        Email = email;
        Telefono = telefono;
    }
// Metodo abtracto
    public void Mostrar()
    {
        Console.WriteLine($"Paciente: {Nombres} {Apellidos}| Cedula:{Cedula}| Email:{Email} | Telefono:{Telefono}");

    }

}
