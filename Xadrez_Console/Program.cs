using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console
{
    class program
    {
        static void Main(string[] Args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + P);

            Console.ReadLine();
        }

        
    }
}