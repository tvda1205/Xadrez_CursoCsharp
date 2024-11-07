using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Curso.tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }

        public Tabuleiro tabuleiro { get; protected set; }

        public Peca( Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            this.tabuleiro = tabuleiro;
            QtdeMovimentos = 0;
        }
    }
}
