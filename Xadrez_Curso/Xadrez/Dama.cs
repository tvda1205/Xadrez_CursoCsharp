using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Curso.tabuleiro;

namespace Xadrez_Curso.Xadrez
{
    class Dama : Peca
    {

        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "D";
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

            // esquerda
            pos.definirValores(Posicao.linha, Posicao.coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.linha, pos.coluna - 1);
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
                pos.definirValores(pos.linha, pos.coluna + 1);
            }

            // acima
            pos.definirValores(Posicao.linha - 1, Posicao.coluna);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna);
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
                pos.definirValores(pos.linha + 1, pos.coluna);
            }

            // NO
            pos.definirValores(Posicao.linha - 1, Posicao.coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna - 1);
            }

            // NE
            pos.definirValores(Posicao.linha - 1, Posicao.coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna + 1);
            }

            // SE
            pos.definirValores(Posicao.linha + 1, Posicao.coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna + 1);
            }

            // SO
            pos.definirValores(Posicao.linha + 1, Posicao.coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna - 1);
            }

            return mat;
        }
    }
}
