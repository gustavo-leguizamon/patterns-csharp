using Patterns.Behavior.Observer.WeatherStation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Observer.WeatherStation.Observers
{
    //Implements IObserver to can get changes from the weatherData object
    //Implements IDisplayElement because our API is going to require all display elements to implement this interface 
    public class CurrentConditionsDisplay : IObserver, IDisplayElement 
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData) //The constructor is passed the weatherData object(the Subject) and we use it to the siaplay as an observer
        {
            _weatherData = weatherData; //Save reference to Subject for un-register or register ourselves as an observer in the future
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("***** Current conditions: *****");
            Console.WriteLine($"Temperature: {_temperature}");
            Console.WriteLine($"Humidity: {_humidity}");
            Console.WriteLine($"Pressure: {_pressure}");
            Console.WriteLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            //When Update() is called, we saved the temp, humidity and pressure, and call Display() to show data
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}
