using System.Globalization;

namespace creacion_de_submodulos;

static class EntradaUsuario
{
    public static double PedirDouble(string mensaje, bool soloPositivos = true)
    {
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine() ?? "";

            if (double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out double resultado))
            {
                if (soloPositivos && resultado <= 0)
                {
                    Console.WriteLine("[Error] El valor debe ser mayor a cero. Intenta de nuevo.");
                    continue;
                }
                return resultado;
            }

            Console.WriteLine("[Error] Entrada no válida. Introduce un número correcto.");
        }
    }
}