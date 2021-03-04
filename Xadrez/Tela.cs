using System;
using tabuleiro;
using Jogo_de_xadrez;
namespace Xadrez {
    class Tela {

        public static void imprimirTab(Tabuleiro tab) {

            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + "");
                for (int j = 0; j < tab.colunas; j++) {
                    if (tab.Peca(i, j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        Tela.imprimirPeca(tab.Peca(i, j));
                        Console.Write("");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(" A B C D E F G H");

        }

        public static PosicaXadrez lerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca) {
            if (peca.cor == Cor.branca) {
                Console.Write(peca);
            }
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
