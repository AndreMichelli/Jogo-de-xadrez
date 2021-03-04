using tabuleiro;
using Jogo_de_xadrez;
using System.Collections.Generic;

namespace Xadrez {
    class PartidaDeXadrez {

        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMov(posicao origem, posicao destino) {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQntdMov();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas() {
            // COLOCA AS PEÇAS
            // PEÇAS PRETAS
            tab.colocarPeca(new Torre(tab, Cor.preta), new PosicaXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.preta), new PosicaXadrez('c', 2).toPosicao());

            // PEÇAS BRANCAS
            tab.colocarPeca(new Torre(tab, Cor.branca), new PosicaXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.branca), new PosicaXadrez('c', 8).toPosicao());

        }

    }
}
