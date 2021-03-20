using Patterns.Behavior.Strategy.DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.DuckSimulator.Behavior
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
