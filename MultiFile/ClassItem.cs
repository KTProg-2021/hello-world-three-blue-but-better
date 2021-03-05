using System;

public class Item
{
	private string _shape;
	private string _color;

	public Item(string shape, string color)
	{
		_shape = shape;
		_color = color;
	}

	public string Shape
    {
		get { return _shape; }
		set { _shape = value; }
    }

	public string Color
    {
		get { return _color; }
		set { _color = value; }
    }

	public void display()
    {
		Console.WriteLine("{0} {1}", _color, _shape);
    }
}
