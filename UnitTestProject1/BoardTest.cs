using System;
using NUnit.Framework;

namespace GoLDataLib.Test
{
  [TestFixture]
  public class BoardTests
  {
    cBoard brd = new cBoard(3,3);

    [Test]
    public void TestNeigbors1()
    {
      brd.setCells(1, 1, new bool[] { true, true, true, true, false, false, false, false, false });
      Assert.IsTrue(brd.countLiveNeighbors(new cCell(1, 1, false)) == 4);

      brd.setCell(2, 2, true);
      Assert.IsTrue(brd.countLiveNeighbors(new cCell(1, 1, false)) == 5);

      brd.setCell(1, 1, true);
      brd.setCell(2, 1, true);
      brd.setCell(0, 2, true);
      brd.setCell(1, 2, true);
      Assert.IsTrue(brd.countLiveNeighbors(new cCell(1, 1, false)) == 8);
    }

    [Test]
    public void TestRule3()
    {
      brd.setCells(1, 1, new bool[] { true, true, true, true, true, false, false, false, false });
      brd.iterate();
      Assert.IsTrue(brd.getCellState(1, 1) == false);
    }

    [Test]
    public void TestRule1()
    {
      brd.setCells(1, 1, new bool[] { true, false, false, false, true, false, false, false, false });
      brd.iterate();
      Assert.IsTrue(brd.getCellState(1, 1) == false);
    }

    [Test]
    public void TestRule2()
    {
      brd.setCells(1, 1, new bool[] { true, true, false, false, true, false, false, false, false });
      brd.iterate();
      Assert.IsTrue(brd.getCellState(1, 1) == true);

      brd.setCells(1, 1, new bool[] { true, true, true, false, true, false, false, false, false });
      brd.iterate();
      Assert.IsTrue(brd.getCellState(1, 1) == true);
    }

    [Test]
    public void TestRule4()
    {
      brd.setCells(1, 1, new bool[] { true, true, false, false, false, false, true, false, false });
      brd.iterate();
      Assert.IsTrue(brd.getCellState(1, 1) == true);
    }
  }
}
