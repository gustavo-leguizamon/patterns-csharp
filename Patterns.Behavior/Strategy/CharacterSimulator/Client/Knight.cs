using Patterns.Behavior.Strategy.CharacterSimulator.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.CharacterSimulator.Client
{
    public class Knight : Character
    {
        public Knight()
        {
            weaponBehavior = new SwordBehavior();
        }
    }
}
