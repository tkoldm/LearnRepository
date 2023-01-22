using WeatherMonitoring.Abstractions;

namespace WeatherMonitoring.Implementations;

public class WeatherData : ISubject
{
    private readonly IList<IObserver> _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;


    public WeatherData()
    {
        _observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        _observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public float GetTemperature() => _temperature;
    public float GetHumidity() => _humidity;
    public float GetPressure() => _pressure;

    public void MeasurementsChanged() => NotifyObservers();

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}