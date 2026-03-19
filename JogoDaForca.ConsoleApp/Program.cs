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

using System.Security.Cryptography;

namespace JogoDaForca.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Jogo da Forca");
            Console.WriteLine("---------------------------");

            // 1. Inicio, deve ser selecionado uma palavra aleatoria de uma lista
            static string geraPalavraAleatoria()
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
                "CAJÚ",
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

                int indiceAleatorio = new Random().Next(palavras.Length);

                string palavraAleatoria = palavras[indiceAleatorio];

                return palavraAleatoria;

            }
            string palavraAleatoria = geraPalavraAleatoria();

            //2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
            //assim como as letras erradas.

            char[] dicaPalavra = new char[palavraAleatoria.Length]; // Inicializa o array de chute com o mesmo tamanho da palavra sorteada
            
            for (int indiceDicaPalavra = 0; indiceDicaPalavra < dicaPalavra.Length; indiceDicaPalavra++) // Preenche o array de chute com underline para representar as letras não adivinhadas
            {
                dicaPalavra[indiceDicaPalavra] = '_';
                //Console.Write(dicaPalavra[indiceDicaPalavra]);
                //Console.ReadLine();
            }

            while (true)
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

                for (int indiceChar = 0; indiceChar <= palavraAleatoria.Length; indiceChar++)
                {
                    //char letra = Convert.ToChar(letraDigitada);

                    char letraAtual = palavraAleatoria[indiceChar]; // se criou a variavel letraAtual para armazenar o caractere do indice
                    //Console.WriteLine(letraAtual);

                    if (letra == letraAtual)
                    {
                        //Console.WriteLine(letra);
                        dicaPalavra[indiceChar] = letraAtual; // se a letra digitada for igual a letra atual, substitui o underline pelo caractere correspondente

               
                    }
                }

            }

            Console.Write("Deseja continuar o jogo ? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
            {
                Console.WriteLine("Obrigado por jogar! Até a próxima!");
                break;
            }
        }
    }
}