using Patterns.Structural.Decorator.Beverages.Interfaces;
using Patterns.Structural.Decorator.Beverages.Interfaces.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Decorator.Beverages.Components
{
    //First, we inherits the Beverage class, since this a Beverage
    public class Expresso : Beverage
    {
        public Expresso()
        {
            desciption = "Expresso"; //To take care of the description, we set this in the constructor for the class. Remember the description instance variable is inherited from Beverage
        }

        public override double Cost()
        {
            return 1.99; //Finally, we need to compute the cost of an Expresso. We don't need to worry about adding in condiments in this class, we just need to return the price of an Expresso: $ 1.99
        }
    }
}
