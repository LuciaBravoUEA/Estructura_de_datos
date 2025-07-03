// hacer un Crear un programa que Crear un programa que permita llevar el registro de permita llevar el registro de los vehículos del est los vehículos del estacionamiento del acionamiento del
//Área de Ingeniería de Sistemas de la Área de Ingeniería de Sistemas de la Universidad ut Universidad utilizando como estructura de ilizando como estructura de
//almacenamiento listas enlazadas. Los datos solicitados por cada vehículo son: placa,
//marca, modelo, año y marca, modelo, año y precio. El programa debe permi precio. El programa debe permitir realizar las sigu tir realizar las siguientes
//operaciones:
//a. Agregar vehículo.
//b. Buscar vehículo por placa.
//c. Ver vehículos por año.
//d. Ver todos los Ver todos los vehículos registrados. vehículos registrados.
//e. Eliminar carro registrado.
class Vehiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public decimal Precio { get; set; }
    public Vehiculo Siguiente { get; set; } = null!;
}

class ListaVehiculos
{
    private Vehiculo cabeza;

    public void AgregarVehiculo(string placa, string marca, string modelo, int año, decimal precio)
    {
        Vehiculo nuevoVehiculo = new Vehiculo
        {
            Placa = placa,
            Marca = marca,
            Modelo = modelo,
            Año = año,
            Precio = precio,
            Siguiente = cabeza
        };
        cabeza = nuevoVehiculo;
    }

    public Vehiculo BuscarVehiculoPorPlaca(string placa)
    {
        Vehiculo actual = cabeza;
        while (actual != null)
        {
            if (actual.Placa == placa)
                return actual;
            actual = actual.Siguiente;
        }
        return null;
    }

    public void VerVehiculosPorAño(int año)
    {
        Vehiculo actual = cabeza;
        bool encontrado = false;
        while (actual != null)
        {
            if (actual.Año == año)
            {
                MostrarVehiculo(actual);
                encontrado = true;
            }
            actual = actual.Siguiente;
        }
        if (!encontrado)
            Console.WriteLine($"No se encontraron vehículos del año {año}.");
    }

    public void VerTodosLosVehiculos()
    {
        Vehiculo actual = cabeza;
        if (actual == null)
        {
            Console.WriteLine("No hay vehículos registrados.");
            return;
        }
        while (actual != null)
        {
            MostrarVehiculo(actual);
            actual = actual.Siguiente;
        }
    }

    public bool EliminarVehiculo(string placa)
    {
        Vehiculo actual = cabeza;
        Vehiculo anterior = null;
        while (actual != null)
        {
            if (actual.Placa == placa)
            {
                if (anterior == null)
                    cabeza = actual.Siguiente;
                else
                    anterior.Siguiente = actual.Siguiente;
                return true;
            }
            anterior = actual;
            actual = actual.Siguiente;
        }
        return false;
    }

    private void MostrarVehiculo(Vehiculo v)
    {
        Console.WriteLine($"Placa: {v.Placa}, Marca: {v.Marca}, Modelo: {v.Modelo}, Año: {v.Año}, Precio: {v.Precio:C}");
    }
}

