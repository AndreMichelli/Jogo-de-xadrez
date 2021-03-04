﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    class Tabuleiro {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public Peca Peca(posicao pos) {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(posicao pos) {
            validarPosicao(pos);
            return Peca(pos) != null;
        }

        public void colocarPeca(Peca p, posicao pos) {

            if (existePeca(pos)) {
                throw new TabuleiroExeption("Já existe uma peça nesta posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(posicao pos) {
            if (Peca(pos) == null) {
                return null;
            }
            Peca aux = Peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;

        }

        public bool posicaoValida(posicao pos) {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas) {
                return false;
            }
            else {
                return true;
            }
        }

        public void validarPosicao(posicao pos) {
            if (!posicaoValida(pos)) {
                throw new TabuleiroExeption("Posição invalida!");
            }
        }
    }
}
