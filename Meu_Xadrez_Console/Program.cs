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

                while(partida.terminada != true)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab,posicoesPossiveis);

                    Console.WriteLine();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.executaMovimento(origem, destino);




                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
