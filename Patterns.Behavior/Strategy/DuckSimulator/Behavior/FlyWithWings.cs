using Patterns.Behavior.Strategy.DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.DuckSimulator.Behavior
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings!!");
        }
    }
}
