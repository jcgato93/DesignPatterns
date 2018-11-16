using System;

namespace AbstractFactory.App.Buttons
{
    public class MacOSButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("You have created MacOSButton.");
        }
    }
}