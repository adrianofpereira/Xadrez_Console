﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez;
using Xadrez_Console.tabuleiro;


namespace Xadrez_Console.xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set;  }
        private int turno;
        private Cor jogadaAtual;
        public bool terminada {  get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro (8, 8);
            turno = 1;
            jogadaAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMoviemnto(Posicao origem , Posicao destino)
        {
            Peca p = tab.retirarPeca (origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada  = tab.retirarPeca (destino);
            tab.colocarPeca(p, destino);
        }
        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
        }
    }
}
