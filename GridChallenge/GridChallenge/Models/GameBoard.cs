using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GridChallenge.Models
{
    public class GameBoard
    {
        public const int Rows = 15;
        public const int Columns = 15;
        public bool[,] boardState;
        public bool isCellChecked = false;

        public GameBoard()
        {
            this.boardState = new bool[Rows, Columns];

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                    this.boardState[row, col] = isCellChecked;
            }
        }

        public bool GetStateOfSpecificCell(int row, int col)
        {
            return boardState[row, col];
        }

        public bool SwitchStateOfCell(int row, int col)
        {
            if (boardState[row, col] == isCellChecked)
                boardState[row, col] = true;
            else
                boardState[row, col] = isCellChecked;

            return boardState[row, col];
        }
    }
}
