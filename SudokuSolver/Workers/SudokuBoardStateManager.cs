using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Workers
{
    class SudokuBoardStateManager
    {
        public string GenerateState(int[,] sudokuBoard)
        {
            StringBuilder key = new StringBuilder();

            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    key.Append(sudokuBoard[row, col]);
                }
            }

            return key.ToString();
        }

        public bool IsSolved(int[,] sudokuBoard)
        {
            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    // after conversion, all empty spots are converted to integer 0
                    // Length > 1 -> if the solution contains more than 1 digit we want to reject it
                    if(sudokuBoard[row, col] == 0 || sudokuBoard[row, col].ToString().Length > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
