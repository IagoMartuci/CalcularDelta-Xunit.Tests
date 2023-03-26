namespace CalcularDelta.Models;
public class Delta
{
    private double a;
    private double b;
    private double c;

    public double getA()
    {
        return a;
    }

    public void setA(double a)
    {
        this.a = a;
    }

    public double getB()
    {
        return b;
    }

    public void setB(double b)
    {
        this.b = b;
    }

    public double getC()
    {
        return c;
    }

    public void setC(double c)
    {
        this.c = c;
    }

    public void RetornarDelta(double resultadoDelta, bool deltaNegativo)
    {
        Console.WriteLine($"Resultado Delta: {resultadoDelta} \nDelta Negativo? {deltaNegativo}");
    }
}

