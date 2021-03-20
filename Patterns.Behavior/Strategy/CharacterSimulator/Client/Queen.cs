using Patterns.Behavior.Strategy.CharacterSimulator.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.CharacterSimulator.Client
{
    public class Queen : Character
    {
        public Queen()
        {
            weaponBehavior = new BowAndArrowBehavior();
        }
    }
}
