using WeatherMonitoring.Abstractions;

namespace WeatherMonitoring.Implementations;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private readonly ISubject _weatherData;
    private readonly IList<float> _temperatureHistory;
    private readonly IList<float> _humidityHistory;
    private readonly IList<float> _pressureHistory;

    public StatisticsDisplay(ISubject weatherData)
    {
        _temperatureHistory = new List<float>();
        _humidityHistory = new List<float>();
        _pressureHistory = new List<float>();
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine(
            $"Humidity {GetStatisticsData(_humidityHistory)}\nPressure {GetStatisticsData(_pressureHistory)}\nTemperature {GetStatisticsData(_temperatureHistory)}");
    }

    public void Update()
    {
        _temperatureHistory.Add(_weatherData.GetTemperature());
        _humidityHistory.Add(_weatherData.GetHumidity());
        _pressureHistory.Add(_weatherData.GetPressure());
        Display();
    }

    private string GetStatisticsData(IList<float> list)
    {
        var max = list.Max();
        var min = list.Min();
        var average = list.Sum() / list.Count;
        return $"Max/Min/Avg: {max}/{min}/{average}";
    }
}