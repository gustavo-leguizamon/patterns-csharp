using Patterns.Behavior.Strategy.DuckSimulator.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.DuckSimulator.Client
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackSound();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Model duck.");
        }
    }
}
