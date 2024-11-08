﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Curso.tabuleiro;

namespace Xadrez_Curso.Xadrez
{
    class Torre : Peca
    {

        public Torre( Tabuleiro tabuleiro , Cor cor) : base(tabuleiro , cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.linha, tabuleiro.coluna];

            Posicao pos = new Posicao(0, 0);

            // acima
            pos.definirValores(Posicao.linha - 1, Posicao.coluna);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            // abaixo
            pos.definirValores(Posicao.linha + 1, Posicao.coluna);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            // direita
            pos.definirValores(Posicao.linha, Posicao.coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            // esquerda
            pos.definirValores(Posicao.linha, Posicao.coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }


    }
}
