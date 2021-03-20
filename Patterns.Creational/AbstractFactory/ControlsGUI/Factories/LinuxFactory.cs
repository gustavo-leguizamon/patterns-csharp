using Patterns.Creational.AbstractFactory.ControlsGUI.Controls.Buttons;
using Patterns.Creational.AbstractFactory.ControlsGUI.Controls.Checkboxes;
using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Buttons;
using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Checkboxes;
using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.AbstractFactory.ControlsGUI.Factories
{
    public class LinuxFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }
    }
}
