using Patterns.Structural.Decorator.Beverages.Interfaces;
using Patterns.Structural.Decorator.Beverages.Interfaces.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Decorator.Beverages.Components
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            desciption = "House blend coffee";
        }

        public override double Cost()
        {
            return .89; //Here's another Beverage. All we do is set the appropiate description, and the correct cost: $ 0.89
        }
    }
}
