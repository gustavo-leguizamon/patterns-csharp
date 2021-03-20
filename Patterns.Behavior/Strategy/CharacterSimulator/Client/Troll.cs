using Patterns.Behavior.Strategy.CharacterSimulator.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.CharacterSimulator.Client
{
    public class Troll : Character
    {
        public Troll()
        {
            weaponBehavior = new AxeBehavior();
        }
    }
}
