using Patterns.Behavior.Strategy.DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.DuckSimulator.Behavior
{
    public class QuackSound : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
