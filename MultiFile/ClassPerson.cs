using System;

public class Person
{
	private string _name;
	private string _height;
	private string _weight;

	public Person(string Name, string Height, string Weight)
	{
		_name = Name;
		_height = Height;
		_weight = Weight;
	
	}

	public string Name
    {
		get { return _name; }
		set { _name = value; }
    }

	public string Height
    {
		get { return _height; }
		set { _height = value; }
    }

	public string Weight
    {
		get { return _weight; }
		set { _weight = value; }
    }

	public void display()
    {
		Console.WriteLine("Name: {0}    Height: {1}    Weight: {2}", _name, _height, _weight);
    }
}
