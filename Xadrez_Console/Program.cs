using System;
using System.Xml.Schema;
using Xadrez_Console.tabuleiro;
using xadrez;
using Xadrez_Console.xadrez;


namespace Xadrez_Console
{
    class program
    {
        static void Main(string[] Args)
        {
            

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                    Console.Write("Detino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.executaMoviemnto(origem, destino);  
                }
                
                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }            
    
}