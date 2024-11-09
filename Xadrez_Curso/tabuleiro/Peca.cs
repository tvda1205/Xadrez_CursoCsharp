using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Curso.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }

        public Tabuleiro tabuleiro { get; protected set; }

        public Peca( Tabuleiro tabuleiro, Cor cor )
        {
            Posicao = null;
            this.tabuleiro = tabuleiro;
            Cor = cor;
            QtdeMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            QtdeMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            QtdeMovimentos--;
        }


        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tabuleiro.linha; i++)
            {
                for (int j = 0; j < tabuleiro.coluna; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
