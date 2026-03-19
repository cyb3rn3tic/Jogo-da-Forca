/*
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
            //Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Jogo da Forca");
            Console.WriteLine("---------------------------");

            // 1. Inicio, deve ser selecionado uma palavra aleatoria de uma lista
            

            string palavraAleatoria = geraPalavraAleatoria();

            char[] dicaPalavra = new char[palavraAleatoria.Length]; // Inicializa o array de chute com o mesmo tamanho da palavra sorteada

            for (int indiceDicaPalavra = 0; indiceDicaPalavra < dicaPalavra.Length; indiceDicaPalavra++) // Preenche o array de chute com underline para representar as letras não adivinhadas
            {
                dicaPalavra[indiceDicaPalavra] = '_';
            }

            //2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
            //assim como as letras erradas.
            bool jogadorGanhou = false;
            bool jogadorPerdeu = false;

            int qtdErros = 0;

            while (!jogadorGanhou && !jogadorPerdeu) //o ! significa negação da variavel
            {
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
                    //char letra = Convert.ToChar(letraDigitada);

                    char letraAtual = palavraAleatoria[indiceChar]; // crio  a variavel letraAtual para armazenar o caractere do indice
                    //Console.WriteLine(letraAtual);

                    if (letra == letraAtual)
                    {
                        //Console.WriteLine(letra);
                        dicaPalavra[indiceChar] = letraAtual; // se a letra digitada for igual a letra atual, substitui o underline pelo caractere correspondente 
                        letraEncontrada = true; // marca que a letra foi encontrada              
                    }
                }

                if (!letraEncontrada) // se a letra não foi encontrada, incrementa a quantidade de erros
                {
                    qtdErros++;
                    Console.WriteLine($"Letra incorreta! Você tem {5 - qtdErros} tentativas restantes.");
                }

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

            Console.WriteLine("Tecle ENTER para continuar...");
            Console.ReadLine();

            Console.Write("Deseja continuar o jogo ? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
            {
                Console.WriteLine("Obrigado por jogar! Até a próxima!");
                break;
            }
        }
    }
    static void preencherAcertadas()
    {
        char[] dicaPalavra = new char[palavraAleatoria.Length]; // Inicializa o array de chute com o mesmo tamanho da palavra sorteada

            for (int indiceDicaPalavra = 0; indiceDicaPalavra < dicaPalavra.Length; indiceDicaPalavra++) // Preenche o array de chute com underline para representar as letras não adivinhadas
            {
                dicaPalavra[indiceDicaPalavra] = '_';
            }
    }

    static void DesenharForca(int quantidadeErros)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Jogo da Forca");
        Console.WriteLine("---------------------------------");

        if (quantidadeErros == 0)
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

        else if (quantidadeErros == 1)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (quantidadeErros == 2)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |         |        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (quantidadeErros == 3)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (quantidadeErros == 4)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (quantidadeErros == 5)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |        / \       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        Console.WriteLine("---------------------------------");
    }

    static bool JogadorDesejaContinuar()
    {
        Console.Write("Deseja continuar o jogo? (s/N): ");
        string? opcaoContinuar = Console.ReadLine()?.ToUpper();

        if (opcaoContinuar != "S")
            return false;

        return true;
    }
}