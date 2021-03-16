using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Checkboxes;
using System;

namespace Patterns.Creational.AbstractFactory.ControlsGUI.Controls.Checkboxes
{
    /// <summary>
    /// This is a variant of a checkbox.
    /// </summary>
    public class MacOSCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("You have created MacOSCheckbox.");
        }
    }
}
