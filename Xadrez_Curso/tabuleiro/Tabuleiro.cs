﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Curso.tabuleiro
{
    class Tabuleiro
    {

        public int linha {  get; set; }
        public int coluna { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
            pecas = new Peca[linha, coluna];
        }

        public Peca peca (int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
           
            pecas[pos.linha, pos.coluna] = p;
            p.Posicao = pos;
        }
    }
}
