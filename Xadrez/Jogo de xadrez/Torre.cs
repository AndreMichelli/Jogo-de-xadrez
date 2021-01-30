using System;
using tabuleiro;

namespace Jogo_de_xadrez {
    class Torre : peca {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "T";
        }
    }
}
