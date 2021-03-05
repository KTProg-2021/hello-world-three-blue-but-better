using System;

public class Coordinate
{
	private int _x;
	private int _y;
	private int _z;

	public Coordinate(int X, int Y, int Z)
	{
		_x = X;
		_y = Y;
		_z = Z;
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
	public int Z
    {
		get { return _x; }
		set { _z = value; }
	}
	public void display()
    {
		Console.WriteLine("X: {0}    Y:{1}     Z:{2}", _x, _y,_z);
    }
}
