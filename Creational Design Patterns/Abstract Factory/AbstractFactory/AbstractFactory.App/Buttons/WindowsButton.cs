using System;

namespace AbstractFactory.App.Buttons
{
    public class WindowsButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("You have created WindowsButton.");
        }
    }
}