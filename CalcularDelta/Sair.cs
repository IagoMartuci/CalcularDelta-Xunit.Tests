namespace CalcularDelta;
public class Sair
{
    public static void SairDoSistema()
    {
        Console.Clear();
        Thread.Sleep(500);
        Console.Write("Saindo");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("Obrigado por utilizar o sistema!");
        Environment.Exit(0);
    }
}
