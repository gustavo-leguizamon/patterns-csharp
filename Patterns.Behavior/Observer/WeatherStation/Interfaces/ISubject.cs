using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Observer.WeatherStation.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
