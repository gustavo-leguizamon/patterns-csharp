using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Observer.WeatherStation.Interfaces
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
