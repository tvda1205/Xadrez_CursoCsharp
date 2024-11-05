
using Xadrez_Curso.tabuleiro;

namespace Xadrez_Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

            p = new Posicao(3, 4);

            Console.WriteLine($"Posição {p}");
            Console.WriteLine();
        }
    }
}
