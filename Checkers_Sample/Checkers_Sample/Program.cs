using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // The line below is needed so Console window can display
            // the black disk and the white circle correctly
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ///TODO: Start the game
			Game newGame = new Game();
            newGame.Start();
            Console.ReadLine();
        }
    }

    public enum Color { White, Black }

    #region Position Struct
    public struct Position
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public Position(int row, int col)
        {
            Row = row;
            Column = col;
        }
    }
    #endregion
}