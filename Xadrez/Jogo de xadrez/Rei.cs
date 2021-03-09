using System;
using tabuleiro;

namespace Jogo_de_xadrez {
    class Rei : Peca {

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "R ";
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
            if (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
            }

            // nordeste
            Pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            if (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
            }

            // direita 
            Pos.definirValores(posicao.linha , posicao.coluna + 1);
            if (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
            }

            // sudeste
            Pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
            }

            // baixo
            Pos.definirValores(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
            }

            // sudoeste
            Pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
            }

            // esquerda
            Pos.definirValores(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
            }

            // noroeste
            Pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posicaoValida(Pos) && podeMover(Pos)) {
                mat[Pos.linha, Pos.coluna] = true;
            }

            return mat;
        }

    }
}
