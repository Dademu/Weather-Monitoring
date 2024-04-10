namespace WeatherMonitoringConsole;
using WeatherMonitoringConsole.interfaces;


public class WeatherStation
{
    public static IDisplay<string> CreateDisplay(string request){
        switch(request){
            case "CurrentConditionDisplay":
                return new CurrentConditionDisplay();
            
            case "StatisticsDisplay":
                return new StatisticsDisplay();
            case "ForecastDisplay":
                return new ForecastDisplay();
            default:
                throw new ArgumentException("Please input one of the following options to proceed with the operation: CurrentConditionDisplay, StatisticsDisplay, ForecastDisplay");            }
        }
    }
