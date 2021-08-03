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
        private PartidaDeXadrez partida;
        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "P";
        }

        

        private bool existeInimigo(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p != null && p.Cor != Cor;
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
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
                if(Tabuleiro.PosicaoValida(pos)&& livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }


                pos.definirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && livre(pos) && QuantidadeMovimentos==0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna-1);
                if (Tabuleiro.PosicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                //jogada especial en passante
                if (Posicao.Linha == 3)
                {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if(Tabuleiro.PosicaoValida(esquerda) && existeInimigo(esquerda)&& Tabuleiro.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[esquerda.Linha-1, esquerda.Coluna] = true;
                    }

                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna +1);
                    if (Tabuleiro.PosicaoValida(direita) && existeInimigo(direita) && Tabuleiro.peca(direita) == partida.vulneravelEnPassant)
                    {
                        mat[direita.Linha-1, direita.Coluna] = true;
                    }

                }
            }


            else
            {
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }


                pos.definirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && livre(pos) && QuantidadeMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna +1);
                if (Tabuleiro.PosicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                //jogada especial en passante
                if (Posicao.Linha == 4)
                {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tabuleiro.PosicaoValida(esquerda) && existeInimigo(esquerda) && Tabuleiro.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[esquerda.Linha+1, esquerda.Coluna] = true;
                    }

                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tabuleiro.PosicaoValida(direita) && existeInimigo(direita) && Tabuleiro.peca(direita) == partida.vulneravelEnPassant)
                    {
                        mat[direita.Linha+1, direita.Coluna] = true;
                    }

                }

            }
            return mat;
            
        }
    }
}
