using System;
using tabuleiro;
using Jogo_de_xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.preta), new posicao(0, 0));
            tab.colocarPeca(new Rei(tab,Cor.preta), new posicao(0, 4));


            Tela.imprimirTab(tab);

            Console.ReadLine();
        }
    }
}
