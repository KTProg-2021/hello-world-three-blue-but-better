using System;

public class Appliance
{
	private string _name;
	private int _cost;

	public Appliance(string Name, int Cost)
	{
		_name = Name;
		_cost = Cost;
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

	public void display()
    {
		Console.WriteLine("{0}: ${1}", _name, _cost);
    }
}
