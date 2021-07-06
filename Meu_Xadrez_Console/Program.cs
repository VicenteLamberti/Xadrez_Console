using TabuleiroNameSpace;
using System;
using XadrezNameSpace;

namespace Meu_Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //PosicaoXadrez pos = new PosicaoXadrez('a',1);
            //Console.WriteLine(pos.ToPosicao());
            //Console.WriteLine(pos);
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.ImprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
