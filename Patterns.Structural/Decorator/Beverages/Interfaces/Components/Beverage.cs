using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Decorator.Beverages.Interfaces.Components
{
    //Beverage is an abstract class(also can be an interface) with th method cost()
    public abstract class Beverage
    {
        protected string desciption;

        //public Beverage()
        //{
        //    desciption = "Unknown Beverage.";
        //}

        public virtual string GetDescription()
        {
            return desciption;
        }

        public abstract double Cost();
    }
}
