/* This is an almost-complete translation of https://github.com/haarismemon/oware/ from Java to C#
*/
using System;

namespace Oware
{
    class Program
    {
        static void Main(string[] args)
        {
            IScoreHouse scores = new ScoreHouse();
            Player one = new Player("Player 1", scores);
            Player two = new Player("Player 2", scores);
            Board b = new Board(one, two);
            // rest left as exercise to reader!
        }
    }
}
