using System;
using tabuleiro;
using Jogo_de_xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {

                    Console.Clear();
                    Tela.imprimirTab(partida.tab);

                    Console.WriteLine();

                    Console.Write("Posição de origem da peça: ");
                    posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Posição de destino da peça: ");
                    posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMov(origem, destino);
                }
            }
            catch (TabuleiroExeption e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
