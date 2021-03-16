using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Buttons;
using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Checkboxes;
using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.AbstractFactory.ControlsGUI
{
    /// <summary>
    /// Factory users don't care which concrete factory they use since they work with factories and products through abstract interfaces.
    /// </summary>
    public class ControlsGUIApplication
    {
        private IButton _button;
        private ICheckbox _checkbox;

        public ControlsGUIApplication(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }
}
