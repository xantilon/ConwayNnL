using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConwayNnL
{
  public partial class Form1 : Form
  {

    private bool isRunning = false;

      
    public Form1()
    {
      InitializeComponent();
      boardControl1.BoardDimension = trackBar1.Value;
    }



    private void button1_Click(object sender, EventArgs e)
    {
      button1.Enabled = false;
      if (isRunning)
      {
        button1.Text = "Go";
        boardControl1.Stop();
      }
      else
      {
        button1.Text = "Stop";
        boardControl1.Run();        
      }
      isRunning = !isRunning;
      button1.Enabled = true;


    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
      boardControl1.BoardDimension = trackBar1.Value;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      boardControl1.BoardDimension = trackBar1.Value;
    }
  }
}
