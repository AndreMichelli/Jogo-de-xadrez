
using tabuleiro;

namespace Xadrez {
    class PosicaXadrez {

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaXadrez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public posicao toPosicao() {
            return new posicao(8 - linha, coluna - 'a');
        }

        public override string ToString() {
            return "" + coluna + linha;
        }

    }
}
