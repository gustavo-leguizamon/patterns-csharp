using Patterns.Behavior.Observer.WeatherStation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Observer.WeatherStation.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private string _weather;
        private ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("***** Forecast: *****");
            Console.WriteLine(_weather);
            Console.WriteLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            if (temperature < 15)
                _weather = "Cold";
            else if (temperature <= 20)
                _weather = "Mild";
            else
                _weather = "Hot";
            Display();
        }
    }
}
