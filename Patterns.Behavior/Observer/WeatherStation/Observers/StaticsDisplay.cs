using Patterns.Behavior.Observer.WeatherStation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Behavior.Observer.WeatherStation.Observers
{
    public class StaticsDisplay : IObserver, IDisplayElement
    {
        private List<float> _temperatures;
        private float _averageTemperature;
        private float _minimumTemperature;
        private float _maximumTemperature;
        private ISubject _weatherData;

        public StaticsDisplay(ISubject subject)
        {
            _weatherData = subject;
            _weatherData.RegisterObserver(this);
            _temperatures = new List<float>();
        }

        public void Display()
        {
            Console.WriteLine("***** Weather Stats: *****");
            Console.WriteLine($"Avg. temperature: {_averageTemperature}");
            Console.WriteLine($"Min. temperature: {_minimumTemperature}");
            Console.WriteLine($"Max. temperature: {_maximumTemperature}");
            Console.WriteLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperatures.Add(temperature); //Add new temp to list

            _averageTemperature = _temperatures.Sum(temp => temp) / _temperatures.Count;
            _minimumTemperature = _temperatures.Min();
            _maximumTemperature = _temperatures.Max();
            Display();
        }
    }
}
