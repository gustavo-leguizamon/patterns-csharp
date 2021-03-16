using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Buttons;
using System;

namespace Patterns.Creational.AbstractFactory.ControlsGUI.Controls.Buttons
{
    /// <summary>
    /// This is a MacOS variant of a button.
    /// </summary>
    public class MacOSButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("You have created MacOSButton.");
        }
    }
}
