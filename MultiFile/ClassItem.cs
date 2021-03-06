using System;

public class Item
{
	private string _shape;
	private string _color;
	private int _weight;
	public Item(string shape, string color, int weight)
	{
		_shape = shape;
		_color = color;
		_weight = weight;
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

	public int Weight
    {
		get { return _weight; }
		set { _weight = value; }
	}

	public void display()
    {
		Console.WriteLine("{0} {1} {2}", _color, _shape, _weight);
    }
}
