using System;

public class Appliance
{
	private string _name;
	private int _cost;
	private string _color;

	public Appliance(string Name, int Cost, string color)
	{
		_name = Name;
		_cost = Cost;
		_color = color;
	}

	public int Cost
    {
		get { return _cost; }
		set { _cost = value; }
    } 

	public string Name
    {
		get { return _name; }
		set { _name = value; }
    }

	public string Color
	{
		get { return _color; }
		set { _color = value; }
	}

	public void display()
    {
		Console.WriteLine("{0}: ${1}, {2}", _name, _cost, _color);
    }
}
