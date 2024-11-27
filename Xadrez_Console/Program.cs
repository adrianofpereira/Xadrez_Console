﻿using System;
using System.Xml.Schema;
using Xadrez_Console.tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class program
    {
        static void Main(string[] Args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }

        
    }
}