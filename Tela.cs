using System;
using tabuleiro;
using xadrez;

namespace xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        //Sobrecarga contendo a matriz de movimentos possiveis impressos na tela
        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis) 
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j]) //Muda a cor no tabuleiro onde o movimento for possivel
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez() //Vai ler uma posicao do usuario para realizar um movimento (origem/destino)
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null) //Testa se existe peca na posicao
            {
                Console.Write("- "); //Imprime traco se for null
            }
            else //Imprime a peca e faz a troca de cores
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }

                else //troca a cor da peca
                {
                    ConsoleColor aux = Console.ForegroundColor; //usa a variavel auxiliar para pegar a cor original e guardar
                    Console.ForegroundColor = ConsoleColor.Yellow; //transform a cor em preta(amarela)
                    Console.Write(peca); //imprime a peca na cor preta(amarela)
                    Console.ForegroundColor = aux; //retorna a cor para a original(aux)
                }
                Console.Write(" ");
            }
        }



    }
}
