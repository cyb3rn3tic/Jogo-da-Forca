namespace JogoDaForca.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Jogo da Forca:");
            Console.WriteLine("---------------------------");

            // 1. Inicio, deve ser selecionado uma palavra aleatoria de uma lista

            Console.Write("Deseja continuar o jogo ? (S/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            JogoDaForca jogo = new JogoDaForca(palavra);
            jogo.Jogar();
        }
    }

    static string EscolherPalavraAleatoria()
    {
        Console.WriteLine
    }

}

