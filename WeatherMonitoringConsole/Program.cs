namespace WeatherMonitoringConsole;

public class Program
{
    public static void Main(string[] arg)
    {
        var weatherData = new WeatherData<string>();
        Console.WriteLine("Please enter your command (CurrentConditionDisplay, StatisticsDisplay, ForecastDisplay: ");

        var obs1 = Console.ReadLine() ?? "";
        weatherData.Subscribe(WeatherStation.CreateDisplay(obs1));
        Console.WriteLine("Enter temperature (This must be a figure): ");
        weatherData.Value = Console.ReadLine() ?? "";
    }
}

