using WeatherMonitoringConsole.interfaces;

namespace WeatherMonitoringConsole;

public class StatisticsDisplay: IDisplay<string>
{
    double answer;
    IList<double> sumUp = new List<double>();
    public void Display(string parameter)
    {
        if(double.TryParse(parameter, out answer))
            sumUp.Add(answer);
        else
            throw new Exception("Input can't be converted to double");
        
        Console.WriteLine("Average Temp: "+ sumUp.Average());
        Console.WriteLine("Minimum Temp: "+ sumUp.Min());
        Console.WriteLine("Minimum Temp: "+ sumUp.Max());
    }

    
}