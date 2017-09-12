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
        
        

    }
}
