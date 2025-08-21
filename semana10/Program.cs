class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // 1. Crear del 1 al 500 ciudadanos
            HashSet<string> ciudadanos = new HashSet<string>();
            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add("Ciudadano " + i);
            }

            //  Crear 75 vacunados solo con Pfizer
            HashSet<string> pfizer = new HashSet<string>();
            while (pfizer.Count < 75)
            {
                int num = rnd.Next(1, 501);
                pfizer.Add("Ciudadano " + num);
            }

            //  Crear 75 vacunados solo con AstraZeneca 
            HashSet<string> astra = new HashSet<string>();
            while (astra.Count < 75)
            {
                int num = rnd.Next(1, 501);
                string ciudadano = "Ciudadano " + num;
                if (!pfizer.Contains(ciudadano))
                    astra.Add(ciudadano);
            }

            //  Crear ciudadanos con ambas dosis (del resto de ciudadanos)
            HashSet<string> restantes = new HashSet<string>(ciudadanos.Except(pfizer.Union(astra)));
            HashSet<string> ambas = new HashSet<string>();
            int dosisAmbas = Math.Min(20, restantes.Count); // máximo 20
            while (ambas.Count < dosisAmbas)
            {
                int index = rnd.Next(0, restantes.Count);
                string ciudadano = restantes.ElementAt(index);
                ambas.Add(ciudadano);
            }

            int opcion;
            do
            {
                Console.WriteLine("\n  MENÚ DE VACUNACIÓN COVID-19 ");
                Console.WriteLine("1. Total de ciudadanos");
                Console.WriteLine("2. Ciudadanos SOLO AstraZeneca");
                Console.WriteLine("3. Ciudadanos SOLO Pfizer");
                Console.WriteLine("4. Ciudadanos con AMBAS dosis");
                Console.WriteLine("5. Ciudadanos NO vacunados");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n  Total de ciudadanos (1-500) ");
                        foreach (string c in ciudadanos) Console.WriteLine(c);
                        break;

                    case 2:
                        // Diferencia: Astra - Ambas
                        HashSet<string> soloAstra = new HashSet<string>(astra.Except(ambas));
                        Console.WriteLine("\nCiudadanos que SOLO recibieron AstraZeneca (" + soloAstra.Count + "):");
                        foreach (string c in soloAstra) Console.WriteLine(c);
                        break;

                    case 3:
                        // Diferencia: Pfizer - Ambas
                        HashSet<string> soloPfizer = new HashSet<string>(pfizer.Except(ambas));
                        Console.WriteLine("\nCiudadanos que SOLO recibieron Pfizer (" + soloPfizer.Count + "):");
                        foreach (string c in soloPfizer) Console.WriteLine(c);
                        break;

                    case 4:
                        // Ciudadanos con ambas dosis
                        Console.WriteLine("\nCiudadanos que recibieron AMBAS dosis (" + ambas.Count + "):");
                        foreach (string c in ambas) Console.WriteLine(c);
                        break;

                    case 5:
                        // Diferencia con Unión: Ciudadanos - (Pfizer ∪ Astra ∪ Ambas)
                        HashSet<string> noVacunados = new HashSet<string>(ciudadanos.Except(pfizer.Union(astra).Union(ambas)));
                        Console.WriteLine("\nCiudadanos que NO se han vacunado (" + noVacunados.Count + "):");
                        foreach (string c in noVacunados) Console.WriteLine(c);
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 0);

            Console.WriteLine("\n FIN DEL REPORTE  ");
        }
    }
