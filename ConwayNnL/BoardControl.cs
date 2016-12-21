using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoLDataLib;

namespace ConwayNnL
{
  public partial class BoardControl : UserControl
  {
    private cBoard brd;
    private Graphics g;
    private Pen pen1 = new Pen(Color.Black);
    private Brush brush1 = new SolidBrush(Color.Black);

    private int _boardDimension = 30;
    private float cellWidth;
    private float cellHeight;
    private bool _running = false;


    public float panelWidth = 2f;

    public int BoardDimension
    {
      get { return _boardDimension; }
      set
      {
        _boardDimension = value;
        brd = new cBoard(_boardDimension, _boardDimension);
        calculateCellSizes();
        Invalidate();
      }
    }


    public void Run() {
        _running = true;
        Task.Factory.StartNew(() =>
        {
          while (_running)
          {
            brd.iterate();
            Invalidate();
            System.Threading.Thread.Sleep(100);
          }
        });
      }

    public  void Stop() { _running = false; }


    public void Reset() {
      brd = new cBoard(_boardDimension, _boardDimension);
      Invalidate();
    }

    public BoardControl()
    {
      InitializeComponent();
      calculateCellSizes();
      brd = new cBoard(_boardDimension, _boardDimension);
    }

    private void calculateCellSizes()
    {
      cellWidth = Width / (float)_boardDimension - panelWidth;
      cellHeight = Height / (float)_boardDimension - panelWidth;
    }

    private void BoardControl_Paint(object sender, PaintEventArgs e)
    {
      g = e.Graphics;

      for (int col = 0; col < _boardDimension; col++)
      {
        for (int row = 0; row < _boardDimension; row++)
        {
          if(brd.getCellState(col,row))
          g.FillRectangle(brush1, col * (cellWidth + panelWidth), row * (cellHeight + panelWidth), cellWidth, cellHeight);
          else
            g.DrawRectangle(pen1, col * (cellWidth + panelWidth), row * (cellHeight + panelWidth), cellWidth, cellHeight);
        }
      }
    }

    /// <summary>
    /// calculate new cell sizes on resize and redraw
    /// </summary>
    private void BoardControl_SizeChanged(object sender, EventArgs e)
    {
      calculateCellSizes();
      Invalidate();
    }

    

  }
}
