using System;
using tabuleiro;

namespace Jogo_de_xadrez {
    class Rei : peca {

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "R";
        }
    }
}
