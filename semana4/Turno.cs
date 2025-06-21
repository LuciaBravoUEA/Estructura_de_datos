// declaramos la clase Turno y contiene doctor,paciente y fecha y hora.
public class Turno
{
    public Paciente Paciente { get; set; }
    public Doctor Doctor { get; set; }
    public string FechaHora { get; set; }
    // Creamos el contructor 
    public Turno(Paciente paciente, Doctor doctor, string fechaHora)
    {
        Paciente = paciente;
        Doctor = doctor;
        FechaHora = fechaHora;
    }
    public void Mostrar()
    {
        Console.WriteLine("\n Turno Registrado");
        Paciente.Mostrar();
        Doctor.Mostrar();
        Console.WriteLine($"Fecha y hora del turno: {FechaHora:dd/MM/yyyy HH:mm}");
    }

}