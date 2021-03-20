using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Checkboxes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.AbstractFactory.ControlsGUI.Controls.Checkboxes
{
    public class LinuxCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("You have created LinuxCheckbox.");
        }
    }
}
