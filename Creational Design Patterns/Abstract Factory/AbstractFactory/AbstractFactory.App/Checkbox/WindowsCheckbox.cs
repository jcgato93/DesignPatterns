using System;

namespace AbstractFactory.App.Checkbox
{
    public class WindowsCheckbox : ICheckbox
    {
        public void paint()
        {
            Console.WriteLine("You have WindowsCheckbox");
        }
    }
}