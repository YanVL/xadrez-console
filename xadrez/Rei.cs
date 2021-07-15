using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
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
            pos.definirValores(posicao.linha - 1, posicao.coluna); //Testa se a posição acima do rei é valida para mover
            if (tab.posicaoValida(pos) && podeMover(pos)) //Teste se a posicao e valida no tabuleiro e se pode mover para o destino
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //NE
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1); //Testa se a posição acima do rei é valida para mover
            if (tab.posicaoValida(pos) && podeMover(pos)) //Teste se a posicao e valida no tabuleiro e se pode mover para o destino
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direita
            pos.definirValores(posicao.linha, posicao.coluna + 1); //Testa se a posição acima do rei é valida para mover
            if (tab.posicaoValida(pos) && podeMover(pos)) //Teste se a posicao e valida no tabuleiro e se pode mover para o destino
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Se
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1); //Testa se a posição acima do rei é valida para mover
            if (tab.posicaoValida(pos) && podeMover(pos)) //Teste se a posicao e valida no tabuleiro e se pode mover para o destino
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna); //Testa se a posição acima do rei é valida para mover
            if (tab.posicaoValida(pos) && podeMover(pos)) //Teste se a posicao e valida no tabuleiro e se pode mover para o destino
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //So
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1); //Testa se a posição acima do rei é valida para mover
            if (tab.posicaoValida(pos) && podeMover(pos)) //Teste se a posicao e valida no tabuleiro e se pode mover para o destino
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1); //Testa se a posição acima do rei é valida para mover
            if (tab.posicaoValida(pos) && podeMover(pos)) //Teste se a posicao e valida no tabuleiro e se pode mover para o destino
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //No
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1); //Testa se a posição acima do rei é valida para mover
            if (tab.posicaoValida(pos) && podeMover(pos)) //Teste se a posicao e valida no tabuleiro e se pode mover para o destino
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
