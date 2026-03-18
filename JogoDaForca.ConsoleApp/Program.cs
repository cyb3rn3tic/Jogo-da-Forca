<<<<<<< HEAD
﻿/*
Requisitos
1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
assim como as letras erradas.
3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
acaba.
4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/

namespace JogoDaForca.ConsoleApp;
=======
﻿namespace JogoDaForca.ConsoleApp;
>>>>>>> e8a3a329bd6847f6b8a53dc8fc5842e15f8d0509
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
<<<<<<< HEAD
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

            //Console.WriteLine($"A palavra secreta é {geraPalavraAleatoria()}");

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

=======
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
>>>>>>> e8a3a329bd6847f6b8a53dc8fc5842e15f8d0509
