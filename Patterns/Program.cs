﻿using Patterns.Behavior.Observer.WeatherStation.Interfaces;
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
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Behavior

            #region Observer

            ObserverWeatherStation();

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

        }

        #region Behavior

        #region Observer

        private static void ObserverWeatherStation()
        {
            WeatherData weatherData = new WeatherData();
            new CurrentConditionsDisplay(weatherData);
            new ForecastDisplay(weatherData);
            new StaticsDisplay(weatherData);

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
    }
}
