using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Curso.tabuleiro;

namespace Xadrez_Curso
{
    class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro tab )
        {
            for (int i = 0; i<tab.linha; i++ )
            {
                for (int j = 0; j < tab.coluna; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.WriteLine(" , ");
                    } else
                    {
                        Console.WriteLine(tab.peca(i,j) + " ")S;
                    }

                    Console.WriteLine();
                }
            }

        }

    }
}
