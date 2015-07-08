using System;
using System.Windows.Forms;

namespace SimpleGames.YellowRed
{
	/// <summary>
	/// Description of Cell.
	/// </summary>
	public class Cell : PictureBox
	{
		public int X { get; private set; }
		public int Y { get; private set; }
		
		public Cell(int i, int j) : base()
		{
			this.X = i;
			this.Y = j;
		}
	}
}
