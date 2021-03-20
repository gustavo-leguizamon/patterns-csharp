using Patterns.Behavior.Strategy.CharacterSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.CharacterSimulator.Behavior
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting and arrow witha bow.");
        }
    }
}
