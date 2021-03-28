using Patterns.Structural.Decorator.Beverages.Interfaces.Components;
using Patterns.Structural.Decorator.Beverages.Interfaces.Decorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Decorator.Beverages.Decorators
{
    public class Whip : CondimentDecorator
    {
        Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + .50;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }
    }
}
