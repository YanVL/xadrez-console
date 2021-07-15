namespace tabuleiro
{
    class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) //Coloca a peca informada na posicao informada 
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos) //Retira uma peca do tabuleiro
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos); //Recebe a peca informada
            aux.posicao = null; //nulifica a posicao da peca
            pecas[pos.linha, pos.coluna] = null; //nulifica a posicao da peca no tabuleiro
            return aux;
        }


        public bool existePeca(Posicao pos) //Teste se existe peca na posicao e se a posicao e valida
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public bool posicaoValida(Posicao pos) //Testa se a posição e valida no tabuleiro
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) //Complemento da posicaoValida, lancando uma excecao personalizada
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }


    }
}
