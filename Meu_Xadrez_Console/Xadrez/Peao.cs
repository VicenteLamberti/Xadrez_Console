using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabuleiroNameSpace;

namespace XadrezNameSpace
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "P";
        }

        

        private bool existeInimigo(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool livre(Posicao pos)
        {
            return Tabuleiro.peca(pos) == null;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);
            
            if(Cor == Cor.Branca)
            {
                Posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna);
                if(Tabuleiro.PosicaoValida(pos)&& livre(pos))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }


                Posicao.definirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && livre(pos) && QuantidadeMovimentos==0)
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                Posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna-1);
                if (Tabuleiro.PosicaoValida(pos) && existeInimigo(pos))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                Posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(pos) && existeInimigo(pos))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }
            }
            else
            {
                Posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && livre(pos))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }


                Posicao.definirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && livre(pos) && QuantidadeMovimentos == 0)
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                Posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(pos) && existeInimigo(pos))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                Posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna +1);
                if (Tabuleiro.PosicaoValida(pos) && existeInimigo(pos))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }
            }
            return mat;
            
        }
    }
}
