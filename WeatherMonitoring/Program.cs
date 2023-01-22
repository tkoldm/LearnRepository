// See https://aka.ms/new-console-template for more information

using WeatherMonitoring.Implementations;

var weatherData = new WeatherData();

var currentConditions = new CurrentConditionsDisplay(weatherData);
var statistics = new StatisticsDisplay(weatherData);

weatherData.SetMeasurements(80, 10, 34);
weatherData.SetMeasurements(0, 60, 54);
weatherData.SetMeasurements(10, 50, 4);
