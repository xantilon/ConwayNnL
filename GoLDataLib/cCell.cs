namespace GoLDataLib
{
  public class cCell
  {
    public int iX { get; set; }
    public int iY { get; set; }

    public bool bIsAlive { get; set; }
    public bool bNextState { get; set; }

    public cCell(int x, int y, bool alive)
    {
      iX = x;
      iY = y;
      bIsAlive = alive;
    }
  }
}
