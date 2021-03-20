using Patterns.Behavior.Strategy.DuckSimulator.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.DuckSimulator.Client
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackSound();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Redhead duck.");
        }
    }
}
