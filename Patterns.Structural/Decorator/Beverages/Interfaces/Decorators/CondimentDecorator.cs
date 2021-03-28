using Patterns.Structural.Decorator.Beverages.Interfaces.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Decorator.Beverages.Interfaces.Decorators
{
    //First, we need to interchangeable with a Beverage, so we inherits the Beverage class
    public abstract class CondimentDecorator : Beverage
    {
        //public abstract new string GetDescription(); //We're also going to require that the condiment decorators all reimplement the GetDescription() method. 
    }
}
