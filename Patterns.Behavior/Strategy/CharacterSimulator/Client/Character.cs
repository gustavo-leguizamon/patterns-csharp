using Patterns.Behavior.Strategy.CharacterSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavior.Strategy.CharacterSimulator.Client
{
    public abstract class Character
    {
        protected IWeaponBehavior weaponBehavior;

        public void Fight()
        {
            weaponBehavior.UseWeapon();
        }

        public void SetWeapon(IWeaponBehavior weaponBehavior)
        {
            this.weaponBehavior = weaponBehavior;
        }
    }
}
