using System;
using tabuleiro;

namespace xadrez_console
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
                    if(tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); ;
            }
            Console.Write("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca) 
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
        }




    }
}
