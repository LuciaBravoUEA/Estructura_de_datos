
// declaramos la clase Agenda
public class Agenda
{
    private Turno[] Turnos;     // usamos un vector.
    private int contador;

    public Agenda(int capacidadMaxima)
    {
        Turnos = new Turno[capacidadMaxima];
        contador = 0;
    }
// Creamos el contructor 
    public void AgregarTurno(Turno turno)
    {
        if (contador < Turnos.Length)
        {
            Turnos[contador] = turno;
            contador++;
            Console.WriteLine("Turno registrado correctamente.");
        }
        else
        {
            Console.WriteLine("No se puede agregar más turnos, agenda llena.");
        }
    }

    public void MostrarTurnos()
    {
        if (contador == 0)
        {
            Console.WriteLine("No hay turnos registrados.");
            return;
        }

        Console.WriteLine("Lista de turnos registrados:");
        for (int i = 0; i < contador; i++)
        {
            Turnos[i].Mostrar();
        }
    }

    public void ConsultarPorCedula(string cedula)
    {
        bool encontrado = false;
        for (int i = 0; i < contador; i++)
        {
            if (Turnos[i].Paciente.Cedula == cedula)
            {
                Turnos[i].Mostrar();
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontró ningún turno con esa cédula.");
        }
    }
}

