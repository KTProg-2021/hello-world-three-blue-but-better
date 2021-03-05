using System;

public class Coordinate
{
	private int _x;
	private int _y;

	public Coordinate(int X, int Y)
	{
		_x = X;
		_y = Y;
	}

	public int X
    {
		get { return _x; }
		set { _x = value; }
    }

	public int Y
    {
		get { return _x; }
		set { _y = value; }
    }
	public void display()
    {
		Console.WriteLine("X: {0}    Y:{1}", _x, _y);
    }
}
