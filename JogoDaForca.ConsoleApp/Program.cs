/*
Requisitos
1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
assim como as letras erradas.
3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
acaba.
4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/

namespace JogoDaForca.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string palavraAleatoria = GeraPalavraAleatoria();

            char[] dicaPalavra = PreencherAcertadas(palavraAleatoria);

            ExecutarJogo(dicaPalavra, palavraAleatoria);

            if (!JogadorDesejaContinuar())
            {
                break;
            }

        }

    }

    // 1. Inicio, deve ser selecionado uma palavra aleatoria de uma lista
    static string GeraPalavraAleatoria()
    {
        string[] palavras = [
        "ABACATE",
        "ABACAXI",
        "ACEROLA",
        "AÇAÍ",
        "ARAÇÁ",
        "ABACATE",
        "BACABA",
        "BACURI",
        "BANANA",
        "CAJÁ",
        "CAJU",
        "CARAMBOLA",
        "CUPUAÇU",
        "GRAVIOLA",
        "GOIABA",
        "JABUTICABA",
        "JENIPAPO",
        "MAÇÃ",
        "MANGABA",
        "MANGA",
        "MARACUJÁ",
        "MURICI",
        "PEQUI",
        "PITANGA",
        "PITAYA",
        "SAPOTI",
        "TANGERINA",
        "UMBU",
        "UVA",
        "UVAIA"
        ];

        int indiceAleatorio = Random.Shared.Next(palavras.Length);

        string palavraAleatoria = palavras[indiceAleatorio];

        return palavraAleatoria;
    }

    // 2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada, assim como as letras erradas.    
    static char[] PreencherAcertadas(string palavraAleatoria)
    {
        char[] dicaPalavra = new char[palavraAleatoria.Length]; // Inicializa o array de chute com o mesmo tamanho da palavra sorteada

        for (int indiceDicaPalavra = 0; indiceDicaPalavra < dicaPalavra.Length; indiceDicaPalavra++) // Preenche o array de chute com underline para representar as letras não adivinhadas
        {
            dicaPalavra[indiceDicaPalavra] = '_';
        }

        return dicaPalavra;
    }
    static void ExecutarJogo(char[] dicaPalavra, string palavraAleatoria)
    {
        bool jogadorGanhou = false;
        bool jogadorPerdeu = false;

        int qtdErros = 0;

        while (!jogadorGanhou && !jogadorPerdeu) //a ! significa negação da variavel
        {

            DesenharForca(qtdErros);
            Console.WriteLine($"\nVocê tem {5 - qtdErros} tentativas restantes.");
            Console.WriteLine(dicaPalavra);

            Console.Write("\nDigite uma letra: ");
            string? letraDigitada = Console.ReadLine()?.ToUpper();

            if (string.IsNullOrWhiteSpace(letraDigitada))
            {
                Console.WriteLine("Digite um caractere válido!");
                Console.ReadLine();
                continue;
            }

            char letra = Convert.ToChar(letraDigitada);
            bool letraEncontrada = false;

            for (int indiceChar = 0; indiceChar < palavraAleatoria.Length; indiceChar++)
            {
                char letraAtual = palavraAleatoria[indiceChar]; // a variavel letraAtual é para armazenar o caractere do indice

                if (letra == letraAtual)
                {
                    dicaPalavra[indiceChar] = letraAtual; // se a letra digitada for igual a letra atual, substitui o underline pelo caractere correspondente 
                    letraEncontrada = true; // marca que a letra foi encontrada              
                }
            }

            if (!letraEncontrada) // se a letra não foi encontrada, incrementa a quantidade de erros
            {
                qtdErros++;
            }

            DesenharForca(qtdErros); // Atualiza o desenho da forca a cada erro

            jogadorGanhou = palavraAleatoria == string.Join("", dicaPalavra); // Verifica se o jogador ganhou comparando a palavra secreta com a dica atualizada

            // 3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida acaba.
            jogadorPerdeu = qtdErros >= 5; // Verifica se o jogador perdeu após 5 erros

            if (jogadorGanhou)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine($"Parabéns! Você acertou a palavra: {palavraAleatoria}");
                Console.WriteLine("=====================================================");
            }

            else if (jogadorPerdeu)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine($"Game Over! A palavra era: {palavraAleatoria}");
                Console.WriteLine("=============================================");
            }


        }
    }

    // 4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
    static void DesenharForca(int qtdDeErros)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Jogo da Forca");
        Console.WriteLine("---------------------------------");

        if (qtdDeErros == 0)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (qtdDeErros == 1)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         O        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (qtdDeErros == 2)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         O        ");
            Console.WriteLine(@" |         |        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (qtdDeErros == 3)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         O        ");
            Console.WriteLine(@" |        /|\        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (qtdDeErros == 4)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         O        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |        / \       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (qtdDeErros == 5)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |        O         ");
            Console.WriteLine(@" |        /|        ");
            Console.WriteLine(@" |        / \       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        Console.WriteLine("---------------------------------");
    }

    // Método para perguntar ao jogador se deseja continuar o jogo
    static bool JogadorDesejaContinuar()
    {
        Console.Write("Deseja continuar o jogo? (s/N): ");
        string? opcaoContinuar = Console.ReadLine()?.ToUpper();

        if (opcaoContinuar != "S")
            return false;           //sintaxe para if/else otimizada

        return true;
    }
}
