using System;
using System.Collections.Generic;

namespace GoLDataLib
{
  public class cBoard
  {
    private int _ulX { get; set; }
    private int _ulY { get; set; }
    private List<List<cCell>> _aBoard = new List<List<cCell>>();

     
    public cBoard(int x, int y)
    {
      _ulX = x;
      _ulY = y;
      setupBoard();
    }

    public void iterate()
    {
      for (int col = 0; col < _ulX; col++)
      {
        for (int row = 0; row < _ulY; row++)
        {
          evalNextCellState(_aBoard[col][row]);
        }
      }

      for (int col = 0; col < _ulX; col++)
      {
        for (int row = 0; row < _ulY; row++)
        {
          _aBoard[col][row].bIsAlive = _aBoard[col][row].bNextState;
        }
      }
    }

    public bool getCellState(int x, int y)
    {
      return _aBoard[x][y].bIsAlive;
    }

    /// <summary>
    /// the game rules are in here
    /// </summary>
    private void evalNextCellState(cCell cell)
    {
      short nb = countLiveNeighbors(cell);
      cell.bNextState = cell.bIsAlive;

      // rules
      // 1. underpopulation: any live cell with fewer than two live neighbours dies
      // 2. Any live cell with two or three live neighbours lives on to the next generation.
      // 3. overpopulation: any live cell with more than three live neighbours dies
      // 4. Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

      // rule 1
      if (nb < 2)
        cell.bNextState = false;

      // rule 2
      //unchanged

      // rule 3
      if (nb > 3)
        cell.bNextState = false;

      // rule 4
      if (!cell.bIsAlive && nb == 3)
        cell.bNextState = true;


    }

    /// <summary>
    /// returns the amount of living neighbor cells
    /// </summary>
    public short countLiveNeighbors(cCell c)
    {
      short lives = 0;
      for (int col = c.iX-1; col <= c.iX+1; col++)
      {
        for (int row = c.iY-1; row <=c.iY+1; row++)
        {
          //don't count self
          if (col == 1 && row == 1)
            continue;

          //don't check borders
          if (col < 0 || col >= _ulX || row < 0 || row >= _ulY)
            continue;

          lives += (_aBoard[col][row].bIsAlive) ? (short)1 : (short)0;
        }

      }
      return lives;
    }

    /// <summary>
    /// 0 | 1 | 2
    /// 3 | c | 4
    /// 5 | 6 | 7
    /// </summary>
    //private bool[] getNeighbourStates(cCell c)
    //{
    //  bool[] ret = new bool[] {
    //       (c.iX == 0 || c.iY == 0)? false : _aBoard[c.iX - 1][ c.iY -1].bIsAlive, // 0 top left
    //                    (c.iY == 0)? false : _aBoard[c.iX - 1][ c.iY -1].bIsAlive, // 1 top middle
    //    (c.iX == _ulX || c.iY == 0)? false : _aBoard[c.iX - 1][ c.iY -1].bIsAlive, // 2 top right
    //                    (c.iX == 0)? false : _aBoard[c.iX - 1][ c.iY -1].bIsAlive, // 3 middle left
    //                 (c.iX == _ulX)? false : _aBoard[c.iX - 1][ c.iY -1].bIsAlive, // 4 middle right
    //    (c.iX == 0 || c.iY == _ulY)? false : _aBoard[c.iX - 1][ c.iY -1].bIsAlive, // 5 bottom left
    //                 (c.iY == _ulY)? false : _aBoard[c.iX - 1][ c.iY -1].bIsAlive, // 6 bottom middle
    // (c.iX == _ulX || c.iY == _ulY)? false : _aBoard[c.iX - 1][ c.iY -1].bIsAlive // 7 bottom right
    //  };
    //  return ret;
    //}  

    private void setupBoard()
    {
      Random rnd = new Random();
      for (int col = 0; col < _ulX; col++)
      {
        List<cCell> boardRow = new List<cCell>(_ulX);
        for (int row = 0; row < _ulY; row++)
        {
          boardRow.Add(new cCell(col, row, rnd.Next(0, 2) == 0 ? false : true));
        }
        _aBoard.Add(boardRow);
      }
    }

    // for testing 
    public void setCell(int x, int y, bool live)
    {
      _aBoard[x][y].bIsAlive = live;
    }

    public void setCells(int x, int y, bool[] live)
    {
      _aBoard[x][y].bIsAlive = live[4];

      _aBoard[x - 1][y - 1].bIsAlive = live[0];
      _aBoard[x][y - 1].bIsAlive = live[1];
      _aBoard[x + 1][y - 1].bIsAlive = live[2];

      _aBoard[x - 1][y].bIsAlive = live[3];
      _aBoard[x + 1][y].bIsAlive = live[5];

      _aBoard[x - 1][y + 1].bIsAlive = live[6];
      _aBoard[x][y + 1].bIsAlive = live[7];
      _aBoard[x + 1][y + 1].bIsAlive = live[8];
    }

  }
}
