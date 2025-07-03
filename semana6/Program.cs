class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMENÚ GENERAL");
            Console.WriteLine("1. Menú de vehículos");
            Console.WriteLine("2. Lista enlazada de números aleatorios");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MenuVehiculos();
                    break;
                case "2":
                    MenuNumeros();
                    break;
                case "3":
                    Console.WriteLine("Programa finalizado.");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void MenuVehiculos()
    {
        ListaVehiculos lista = new ListaVehiculos();
        while (true)
        {
            Console.WriteLine("\nMENÚ VEHÍCULOS");
            Console.WriteLine("1. Agregar vehículo");
            Console.WriteLine("2. Buscar vehículo por placa");
            Console.WriteLine("3. Ver vehículos por año");
            Console.WriteLine("4. Ver todos los vehículos registrados");
            Console.WriteLine("5. Eliminar vehículo por placa");
            Console.WriteLine("6. Volver al menú general");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la placa: ");
                    string placa = Console.ReadLine();
                    Console.Write("Ingrese la marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Ingrese el modelo: ");
                    string modelo = Console.ReadLine();

                    Console.Write("Ingrese el año: ");
                    if (!int.TryParse(Console.ReadLine(), out int año))
                    {
                        Console.WriteLine("Año inválido.");
                        break;
                    }

                    Console.Write("Ingrese el precio: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
                    {
                        Console.WriteLine("Precio inválido.");
                        break;
                    }

                    lista.AgregarVehiculo(placa, marca, modelo, año, precio);
                    Console.WriteLine("Vehículo agregado exitosamente.");
                    break;

                case "2":
                    Console.Write("Ingrese la placa a buscar: ");
                    Vehiculo encontrado = lista.BuscarVehiculoPorPlaca(Console.ReadLine());
                    if (encontrado != null)
                        Console.WriteLine($"Placa: {encontrado.Placa}, Marca: {encontrado.Marca}, Modelo: {encontrado.Modelo}, Año: {encontrado.Año}, Precio: {encontrado.Precio:C}");
                    else
                        Console.WriteLine("Vehículo no encontrado.");
                    break;

                case "3":
                    Console.Write("Ingrese el año a buscar: ");
                    if (int.TryParse(Console.ReadLine(), out int añoBuscar))
                        lista.VerVehiculosPorAño(añoBuscar);
                    else
                        Console.WriteLine("Año inválido.");
                    break;

                case "4":
                    lista.VerTodosLosVehiculos();
                    break;

                case "5":
                    Console.Write("Ingrese la placa del vehículo a eliminar: ");
                    if (lista.EliminarVehiculo(Console.ReadLine()))
                        Console.WriteLine("Vehículo eliminado exitosamente.");
                    else
                        Console.WriteLine("Vehículo no encontrado.");
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    static void MenuNumeros()
    {
        ListaEnlazada lista = new ListaEnlazada();
        Random random = new Random();

        for (int i = 0; i < 50; i++)
        {
            int numero = random.Next(1, 1000);
            lista.Agregar(numero);
        }

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        Console.Write("Ingrese el valor mínimo del rango: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(Console.ReadLine());

        lista.EliminarFueraDeRango(min, max);

        Console.WriteLine($"Lista después de eliminar elementos fuera del rango [{min}, {max}]:");
        lista.Mostrar();
    }
}

