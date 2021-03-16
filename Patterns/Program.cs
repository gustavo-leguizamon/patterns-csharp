using Patterns.Creational.AbstractFactory.ControlsGUI;
using Patterns.Creational.AbstractFactory.ControlsGUI.Enums;
using Patterns.Creational.AbstractFactory.ControlsGUI.Factories;
using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Factories;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlsGUIApplication app = ConfigureControlsGUIApplication();
            app.Paint();
        }


        #region Abstract Factory

        /// <summary>
        /// Application picks the factory type and creates it in run time(usually at initialization stage), depending on the configuration or environment variables.
        /// </summary>
        /// <returns></returns>
        private static ControlsGUIApplication ConfigureControlsGUIApplication()
        {
            ControlsGUIApplication app;
            IGUIFactory factory;
            OS os = OS.MAC;
            if (os == OS.MAC)
            {
                factory = new MacOSFactory();
                app = new ControlsGUIApplication(factory);
            }
            else
            {
                factory = new WindowsFactory();
                app = new ControlsGUIApplication(factory);
            }
            return app;
        }

        #endregion
    }
}
