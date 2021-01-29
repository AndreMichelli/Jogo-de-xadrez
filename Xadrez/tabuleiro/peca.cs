using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    class peca {

        public posicao posicao { get; set; }
        public cor cor { get; protected set; }
        public int qntMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public peca(posicao posicao, Tabuleiro tab, cor cor) {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qntMovimentos = 0;
        }

    }
}
