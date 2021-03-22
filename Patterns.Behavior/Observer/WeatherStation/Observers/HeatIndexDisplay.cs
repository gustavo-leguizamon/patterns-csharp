using Patterns.Behavior.Observer.WeatherStation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Observer.WeatherStation.Observers
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private float _heatIndex;
        private ISubject _weatherData;

        public HeatIndexDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("***** HeatIndex: *****");
            Console.WriteLine($"The heat index is: {_heatIndex}");
            Console.WriteLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            //Calculos not exact
            _heatIndex = 16.923f + 
                1.85212f * (float)Math.Pow(10, -1) * temperature + 
                5.37941f * humidity - 
                1.00254f * (float)Math.Pow(10, -1) * temperature * humidity + 
                9.41695f * (float)Math.Pow(10, -3) * (float)Math.Pow(temperature, 2) + 
                7.28898f * (float)Math.Pow(10, -3) * (float)Math.Pow(humidity, 2) + 
                3.45372f * (float)Math.Pow(10, -4) * (float)Math.Pow(temperature, 2) * humidity - 
                8.14971f * (float)Math.Pow(10, -4) * temperature * (float)Math.Pow(humidity, 2) + 
                1.02102f * (float)Math.Pow(10, -5) * (float)Math.Pow(temperature, 2) * (float)Math.Pow(humidity, 2) - 
                3.8646f * (float)Math.Pow(10, -5) * (float)Math.Pow(temperature, 3) + 
                2.91583f * (float)Math.Pow(10, -5) * (float)Math.Pow(humidity, 3) + 
                1.42721f * (float)Math.Pow(10, -6) * (float)Math.Pow(temperature, 3) * humidity + 
                1.97483f * (float)Math.Pow(10, -7) * temperature * (float)Math.Pow(humidity, 3) - 
                2.18429f * (float)Math.Pow(10, -8) * (float)Math.Pow(temperature, 3) * (float)Math.Pow(humidity, 2) + 
                8.43296f * (float)Math.Pow(10, -10) * (float)Math.Pow(temperature, 2) * (float)Math.Pow(humidity, 3) - 
                4.81975f * (float)Math.Pow(10, -11) * (float)Math.Pow(temperature, 3) * (float)Math.Pow(humidity, 3);
            Display();
        }
    }
}
