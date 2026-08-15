namespace creacion_de_submodulos;

static class Calculos
{
    public static double CalcularVelocidad(double distanciaMetros, double tiempoSegundos)
    {
        return distanciaMetros / tiempoSegundos;
    }

    public static double CalcularDistancia(double velocidadMs, double tiempoSegundos)
    {
        return velocidadMs * tiempoSegundos;
    }

    public static double CalcularTiempo(double distanciaMetros, double velocidadMs)
    {
        return distanciaMetros / velocidadMs;
    }
}