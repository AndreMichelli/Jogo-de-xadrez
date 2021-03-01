using System;
using tabuleiro;
namespace Xadrez {
    class Tela {

        public static void imprimirTab(Tabuleiro tab) {

            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + "");
                for (int j = 0; j < tab.colunas; j++) {
                    if (tab.Peca(i, j) == null) {
                        Console.Write(" _");
                    }
                    else {
                        Tela.imprimirPeca(tab.Peca(i, j));
                        Console.Write("");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
            
        }

        public static void imprimirPeca(Peca peca) {
            if (peca.cor == Cor.branca) {
                Console.WriteLine(peca);
            }
            else{
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
