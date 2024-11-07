using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Curso.tabuleiro;

namespace Xadrez_Curso.Xadrez
{
    class Rei : Peca
    {

       public Rei(Cor cor, Tabuleiro tab) : base(cor, tab) { 
        
        }

        public override string ToString()
        {
            return "R";
        }

    }
}
