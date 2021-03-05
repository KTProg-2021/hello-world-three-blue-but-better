using System;

public class Automobile
{
	private string _make;
	private string _model;

	public Automobile(string Make, string Model)
	{
		_make = Make;
		_model = Model;
	}

	public string Make
    {
		get { return _make; }
		set { _make = value; }
    }

	public string Model
    {
		get { return _model; }
		set { _model = value; }
    }

	public void display()
    {
		Console.WriteLine("Vehicle: {0} {1}", _make, _model);
    }
}
