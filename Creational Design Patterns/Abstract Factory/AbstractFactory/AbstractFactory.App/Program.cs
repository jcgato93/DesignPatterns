using AbstractFactory.App.app;
using AbstractFactory.App.Factories;
using System;

namespace AbstractFactory.App
{
    class Program
    {

        private static Application configureApplication()
        {
            Application app;
            GUIFactory factory;

            PlatformID OsName = Environment.OSVersion.Platform;

            if (OsName == PlatformID.Unix)
            {
                factory = new MacOSFactory();
                app = new Application(factory);
            }
            else
            {
                factory = new WindowsFactory();
                app = new Application(factory);
            }

            return app;
        }


        static void Main(string[] args)
        {
            Application app = configureApplication();
            app.paint();
        }
    }
}
