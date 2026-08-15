namespace creacion_de_submodulos;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();
            string opcion = Console.ReadLine() ?? "0";
            continuar = ProcesarOpcion(opcion);
        }
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine("       CALCULADORA DE CINEMÁTICA        ");
        Console.WriteLine("========================================");
        Console.WriteLine(" 1. Calcular Velocidad (v = d / t)      ");
        Console.WriteLine(" 2. Calcular Distancia (d = v * t)      ");
        Console.WriteLine(" 3. Calcular Tiempo    (t = d / v)      ");
        Console.WriteLine(" 0. Salir                               ");
        Console.WriteLine("========================================");
        Console.Write("\nElige una opción: ");
    }

    static bool ProcesarOpcion(string opcion)
    {
        Console.WriteLine();
        switch (opcion.Trim())
        {
            case "1":
                {
                    double distancia = EntradaUsuario.PedirDouble("Introduce la Distancia (m): ");
                    double tiempo = EntradaUsuario.PedirDouble("Introduce el Tiempo (s): ");
                    double velocidad = Calculos.CalcularVelocidad(distancia, tiempo);
                    Console.WriteLine($"\n[Resultado] Velocidad calculada: {velocidad:F2} m/s");
                    break;
                }
            case "2":
                {
                    double velocidad = EntradaUsuario.PedirDouble("Introduce la Velocidad (m/s): ");
                    double tiempo = EntradaUsuario.PedirDouble("Introduce el Tiempo (s): ");
                    double distancia = Calculos.CalcularDistancia(velocidad, tiempo);
                    Console.WriteLine($"\n[Resultado] Distancia calculada: {distancia:F2} metros");
                    break;
                }
            case "3":
                {
                    double distancia = EntradaUsuario.PedirDouble("Introduce la Distancia (m): ");
                    double velocidad = EntradaUsuario.PedirDouble("Introduce la Velocidad (m/s): ");
                    double tiempo = Calculos.CalcularTiempo(distancia, velocidad);
                    Console.WriteLine($"\n[Resultado] Tiempo calculado: {tiempo:F2} segundos");
                    break;
                }
            case "0":
                Console.WriteLine("Saliendo de la aplicación. ¡Hasta luego!");
                return false;
            default:
                Console.WriteLine("[Error] Opción no válida.");
                break;
        }

        Console.WriteLine("\nPresiona cualquier tecla para continuar...");
        Console.ReadKey();
        return true;
    }
}