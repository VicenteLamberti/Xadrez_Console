using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroNameSpace
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        

        public Peca(Tabuleiro tab, Cor cor) 
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tabuleiro = tab;
            this.QuantidadeMovimentos = 0;

        }

        public void incrementarQteMovimento()
        {
            QuantidadeMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i = 0;i < Tabuleiro.Linhas; i++)
            {
                for(int j =0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public abstract bool[,] movimentosPossiveis();
        

        

        
    }
}
