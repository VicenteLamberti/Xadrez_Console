using TabuleiroNameSpace;
using System;
using XadrezNameSpace;

namespace Meu_Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 3));

            Tela.ImprimirTabuleiro(tab);
            
        }
    }
}
