using System;
using tabuleiro;

namespace Jogo_de_xadrez {
    class Torre : Peca {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        private bool podeMover(posicao pos) {
            Peca p = tab.Peca(pos);
            return p == null || p.cor != this.cor;
        }

        public override bool[,] movimentosPosiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            posicao Pos = new posicao(0, 0);
            // acima
            Pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
                if (tab.Peca(Pos) != null && tab.Peca(Pos).cor != cor) {
                    break;
                }
                Pos.linha = Pos.linha - 1;
            }

            // baixo
            Pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
                if (tab.Peca(Pos) != null && tab.Peca(Pos).cor != cor) {
                    break;
                }
                Pos.linha = Pos.linha + 1;
            }

            // direita
            Pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
                if (tab.Peca(Pos) != null && tab.Peca(Pos).cor != cor) {
                    break;
                }
                Pos.linha = Pos.coluna + 1;
            }

            // esquerda
            Pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
                if (tab.Peca(Pos) != null && tab.Peca(Pos).cor != cor) {
                    break;
                }
                Pos.linha = Pos.coluna - 1;
            }

            return mat;
        }

        public override string ToString() {
            return "T ";
        }
    }
}
