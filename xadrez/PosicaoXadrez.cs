﻿using tabuleiro; 

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha  { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()//transforma a posicao do xadrez na posicao da matriz
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }



    }
}
