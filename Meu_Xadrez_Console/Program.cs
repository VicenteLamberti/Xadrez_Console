using TabuleiroNameSpace;
using System;

namespace Meu_Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao posicao = new Posicao(3, 4);

            Console.WriteLine(posicao);

            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            
        }
    }
}
