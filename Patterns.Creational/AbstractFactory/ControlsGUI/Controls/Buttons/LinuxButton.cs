using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Buttons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.AbstractFactory.ControlsGUI.Controls.Buttons
{
    public class LinuxButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("You have created LinuxButton.");
        }
    }
}
