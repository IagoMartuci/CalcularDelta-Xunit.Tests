using CalcularDelta.Models;

namespace CalcularDelta;
public class Calcular
{
    public static void CalcularDelta()
    {
        Delta delta = new Delta();

        Console.Clear();
        Console.Write("Digite o valor de 'A' para calcular o Delta: ");
        delta.setA(double.Parse(Console.ReadLine()));
        Console.Write("Digite o valor de 'B' para calcular o Delta: ");
        delta.setB(double.Parse(Console.ReadLine()));
        Console.Write("Digite o valor de 'C' para calcular o Delta: ");
        delta.setC(double.Parse(Console.ReadLine()));
        double resultadoDelta = CalcularDeltaService.Delta(delta.getA(), delta.getB(), delta.getC());
        delta.RetornarDelta(resultadoDelta, VerificarDeltaNegativo(resultadoDelta));
        Console.ReadKey();
    }

    public static bool VerificarDeltaNegativo(double resultadoDelta)
    {
        bool deltaNegativo;

        if (resultadoDelta < 0)
            deltaNegativo = true;
        else
            deltaNegativo = false;

        return deltaNegativo;
    }
}
