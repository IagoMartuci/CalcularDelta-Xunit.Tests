namespace CalcularDelta.Tests;
public class CalcularDeltaServiceTest
{
    [Fact]
    public void CalcularDelta()
    {
        double a = 1;
        double b = -1;
        double c = -30;
        double resultadoDelta = CalcularDeltaService.Delta(a, b, c);
        Assert.Equal(121, resultadoDelta);
    }

    [Fact]
    public void CalcularDeltaNegativo()
    {
        double a = 7;
        double b = 3;
        double c = 4;
        double resultadoDelta = CalcularDeltaService.Delta(a, b, c);
        Assert.Equal(-103, resultadoDelta);
    }
}