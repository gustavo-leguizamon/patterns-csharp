using Patterns.Behavior.Observer.WeatherStation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Observer.WeatherStation.Subjects
{
    public class WeatherData : ISubject //WeatherData now implements ISubject interface
    {
        private List<IObserver> _observers { get; set; } //Added a list to holod Observers
        private float _temperature { get; set; }
        private float _humidity { get; set; }
        private float _pressure { get; set; }

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObservers() //This is where we tell all the observers about the state. Because they are all Observers, we know they all implement Update(), so we know how to notify them
        {
            foreach (var observer in _observers)
                observer.Update(_temperature, _humidity, _pressure);
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer); //When an observer registers, just add it to the end of the list
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer); //Likewise, when an observer wants to un-register, justtake it off the list
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
