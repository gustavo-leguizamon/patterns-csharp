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
    /// <summary>
    /// Each concrete factory extends basic factory and responsible for creating products of a single variety.
    /// </summary>
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
