using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool podeMover(Posicao pos) //Testa se a posicao está livre para mover
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor; //Teste os casos onde pode mover (espaço vazio ou peça de outra cor);
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas]; //Matriz de movimentos possiveis que percorre toda todas as posicoes

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) 
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) //Utiliza if pois quando o podeMover bater em outra peca, para a contagem
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }
            //Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) //Utiliza if pois quando o podeMover bater em outra peca, para a contagem
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }
            //Direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) //Utiliza if pois quando o podeMover bater em outra peca, para a contagem
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }
            //Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) //Utiliza if pois quando o podeMover bater em outra peca, para a contagem
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }
            return mat;
        }




    }
}
