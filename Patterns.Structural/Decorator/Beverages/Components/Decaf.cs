using Patterns.Structural.Decorator.Beverages.Interfaces;
using Patterns.Structural.Decorator.Beverages.Interfaces.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Decorator.Beverages.Components
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            desciption = "Decaf coffee";
        }

        public override double Cost()
        {
            return 1.37;
        }
    }
}
