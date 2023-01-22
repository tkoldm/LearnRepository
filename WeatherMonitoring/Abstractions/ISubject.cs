namespace WeatherMonitoring.Abstractions;

public interface ISubject
{
    float GetTemperature();
    float GetHumidity();
    float GetPressure();
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}