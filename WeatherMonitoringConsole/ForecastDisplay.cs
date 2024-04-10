using WeatherMonitoringConsole.interfaces;

namespace WeatherMonitoringConsole;

public class ForecastDisplay: IDisplay<string>
{
    private double result;
    public void Display(String param){
        if(double.TryParse(param, out result))
        {
            switch(result){
            case <= -20.0: 
                Console.WriteLine("{0}°C: The forecast warns of impending rain! ", result);
                break;

            case <= -5.0: 
                 Console.WriteLine("{0}°C: The forecast warns of impending rain! ", result);
                 break;
            case <= 10.0: 
                 Console.WriteLine("{0}°C: A mix of sunshine and clouds! ", result);
                 break;
            case <= 25.0: 
                 Console.WriteLine("{0}°C: Bright skies this week.! ", result);
                 break;
            case <=35.0: 
                 Console.WriteLine("{0}°C: The weather is warm and inviting! ", result);
                 break;
            default:
                throw new Exception("wrong value: enter a valid number");
            };
        }
    }
}
    