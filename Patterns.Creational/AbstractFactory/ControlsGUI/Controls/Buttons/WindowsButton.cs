using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Buttons;
using System;

namespace Patterns.Creational.AbstractFactory.ControlsGUI.Controls.Buttons
{
    /// <summary>
    /// This is a Windows variant of a button.
    /// </summary>
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("You have created WindowsButton.");
        }
    }
}
