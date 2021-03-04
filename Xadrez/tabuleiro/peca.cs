using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    class Peca {

        public posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qntdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qntdMovimentos = 0;
        }

        public void incrementarQntdMov() {
            qntdMovimentos++;
        }

    }
}
