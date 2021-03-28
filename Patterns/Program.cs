using Patterns.Behavior.Observer.WeatherStation.Interfaces;
using Patterns.Behavior.Observer.WeatherStation.Observers;
using Patterns.Behavior.Observer.WeatherStation.Subjects;
using Patterns.Behavior.Strategy.CharacterSimulator.Behavior;
using Patterns.Behavior.Strategy.CharacterSimulator.Client;
using Patterns.Behavior.Strategy.DuckSimulator.Behavior;
using Patterns.Behavior.Strategy.DuckSimulator.Client;
using Patterns.Creational.AbstractFactory.ControlsGUI;
using Patterns.Creational.AbstractFactory.ControlsGUI.Enums;
using Patterns.Creational.AbstractFactory.ControlsGUI.Factories;
using Patterns.Creational.AbstractFactory.ControlsGUI.Interfaces.Factories;
using Patterns.Structural.Decorator.Beverages.Components;
using Patterns.Structural.Decorator.Beverages.Decorators;
using Patterns.Structural.Decorator.Beverages.Interfaces.Components;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Behavior

            #region Observer

            //ObserverWeatherStation();

            #endregion

            #region Strategy

            //StrategyDuckSimulator();

            //StrategyCharacterSimulator();

            #endregion

            #endregion

            #region Creational

            #region Abstract Factory

            //ControlsGUIApplication app = ConfigureControlsGUIApplication();
            //app.Paint();

            #endregion

            #endregion

            #region Structural

            DecoratorBeverages();

            #endregion
        }

        #region Behavior

        #region Observer

        private static void ObserverWeatherStation()
        {
            WeatherData weatherData = new WeatherData();
            new CurrentConditionsDisplay(weatherData);
            new ForecastDisplay(weatherData);
            new StaticsDisplay(weatherData);
            new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(20, 40, 23);
            weatherData.SetMeasurements(10, 50, 9);
            weatherData.SetMeasurements(28, 3, 67);
        }

        #endregion

        #region Strategy

        private static void StrategyDuckSimulator()
        {
            Duck mallarDuck = new MallardDuck();
            mallarDuck.Display();
            mallarDuck.PerformFly();
            mallarDuck.PerformQuack();
            mallarDuck.Swim();

            Duck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
            decoyDuck.Swim();
            decoyDuck.SetFlyBehavior(new FlyRocketPowered());
            decoyDuck.PerformFly();
        }

        private static void StrategyCharacterSimulator()
        {
            Character king = new King();
            king.Fight();
            Console.WriteLine("Changing weapon...");
            king.SetWeapon(new KnifeBehavior());
            king.Fight();
        }

        #endregion

        #endregion


        #region Creational

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

        #endregion

        #region Structural

        #region Decorator

        private static void DecoratorBeverages()
        {
            //Order up an expresso, no condiments and print its description and cost
            Beverage expresso = new Expresso();
            Console.WriteLine($"Beverage: {expresso.GetDescription()}, $ {expresso.Cost()}");

            //Make dark roast
            Beverage darkRoastBeverage = new DarkRoast();
            darkRoastBeverage = new Mocha(darkRoastBeverage); //Wrap it with a Mocha.
            darkRoastBeverage = new Mocha(darkRoastBeverage); //Wrap it in a second Mocha.
            darkRoastBeverage = new Whip(darkRoastBeverage); //Wrap it in a Whip.
            Console.WriteLine($"Beverage: {darkRoastBeverage.GetDescription()}, $ {darkRoastBeverage.Cost()}");

            //Finally, give us a HouseBlend with Soy, Mocha, and Whip
            Beverage houseBlendBeverage = new HouseBlend();
            houseBlendBeverage = new Soy(houseBlendBeverage);
            houseBlendBeverage = new Mocha(houseBlendBeverage);
            houseBlendBeverage = new Whip(houseBlendBeverage);
            Console.WriteLine($"Beverage: {houseBlendBeverage.GetDescription()}, $ {houseBlendBeverage.Cost()}");
        }

        #endregion

        #endregion
    }
}
