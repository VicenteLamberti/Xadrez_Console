using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroNameSpace
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro()
        {

        }

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            this.pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return this.pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            this.pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
