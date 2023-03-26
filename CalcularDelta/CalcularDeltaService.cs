namespace CalcularDelta;
public class CalcularDeltaService
{
    public static double Delta(double a, double b, double c)
    {
        double resultadoDelta = ((b * b) - (4 * a * c));
        return resultadoDelta;
    }
}
