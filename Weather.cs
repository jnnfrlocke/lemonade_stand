using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather 
    {
        public double temperature = 75;
        public string sunny = "partly cloudy";
        public double wind = 5;
        public double humidity = 60;

        public double Temp()
        {
            temperature = 75;
            return temperature;
        }

        public string Sun()
        {
            sunny = "partly cloudy";
            return sunny;
        }

        public double WindSpeed()
        {
            wind = 5;
            return wind;
        }

        public double Humid()
        {
            humidity = 60;
            return humidity;
        }

        public void DisplayTodaysWeather()
        {   
            Console.WriteLine($"Today the temperature is forecast to be {temperature} degrees Farenheit. \nIt will be {sunny} with winds of {wind}mph and {humidity}% humidity. \nPress enter to continue.");
            Console.ReadLine();
        }

    }
}
