﻿using TabuleiroNameSpace;
using System;

namespace Meu_Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tabuleiro);
            
        }
    }
}
