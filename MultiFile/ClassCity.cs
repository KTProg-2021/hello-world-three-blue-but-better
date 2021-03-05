using System;

public class City
{
	private string _cityName;
	private string _state;

	public City(string Name, string State)
	{
		_cityName = Name;
		_state = State;
	}

	public string CityName
    {
		get { return _cityName; }
		set { _cityName = value; }
    }

	public string State
    {
		get { return _state; }
		set { _state = value; }
    }

	public void display()
    {
		Console.WriteLine("{0},  {1}", _cityName, _state);
    }
}
