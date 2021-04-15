using System;

public class City
{
	private string _cityName;
	private string _state;
	private int _population;

	public City(string Name, string State, int Population)
	{
		_cityName = Name;
		_state = State;
		_population = Population;
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

	public int Population
	{
		get { return _population; }
		set { _population = value; }
	}



	public void display()
    {
		Console.WriteLine("{0},  {1}, {2}", _cityName, _state, _population);
    }
}
