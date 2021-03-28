using Patterns.Structural.Decorator.Beverages.Interfaces.Components;
using Patterns.Structural.Decorator.Beverages.Interfaces.Decorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Decorator.Beverages.Decorators
{
    //Mocha is a decorator, so we inherit from CondimentDecorator. And CondimentDecorator is a Beverage
    public class Mocha : CondimentDecorator
    {
        //We're going to instantiate Mocha with a reference to a Beverage using:
        //  (1) An instance variable to hold the beverage we are wrapping.
        //  (2) A way to set this instance variable to the object we are wrapping. Here, we're going to pass the beverage we're wrapping to the decorator's constructor.
        private Beverage _beverage; 

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }
    }
}
