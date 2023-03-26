namespace CalcularDelta;
public class MenuClass
{
    public static void Menu()
    {
        char opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("Fórmula de Cálculo: Delta = b² – 4.a.c");
            Console.WriteLine("C - Calcular o Delta");
            Console.WriteLine("S - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = char.Parse(Console.ReadLine().ToUpper());

            switch (opcao)
            {
                case 'C':
                    Calcular.CalcularDelta();
                    break;
                case 'S':
                    Sair.SairDoSistema();
                    break;
                default:
                    Menu();
                    break;
            }
        } while (opcao.Equals('C'));
    }
}
