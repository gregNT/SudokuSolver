using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Strategies
{
    // Our layer of abstraction
    interface ISudokuStrategy
    {
        int[,] Solve(int[,] sudokuBoard);
    }
}
