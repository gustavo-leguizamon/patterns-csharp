using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Buttons;
using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Controls.Checkboxes;

namespace Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Factories
{
    /// <summary>
    /// Abstract factory knows about all (abstract) product types.
    /// </summary>
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
