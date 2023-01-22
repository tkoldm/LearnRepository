using WeatherMonitoring.Abstractions;

namespace WeatherMonitoring.Implementations;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private float _pressure;
    private readonly ISubject _weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions:\nTemperature: {_temperature}\nHumidity: {_humidity}\nPressure: {_pressure}");
    }

    public void Update()
    {
        _temperature = _weatherData.GetTemperature();
        _humidity = _weatherData.GetHumidity();
        _pressure = _weatherData.GetPressure();
        Display();
    }
}