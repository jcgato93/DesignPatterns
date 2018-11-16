using System;

namespace AbstractFactory.App.Checkbox
{
    public class MacOSCheckbox : ICheckbox
    {
        public void paint()
        {
            Console.WriteLine("You have created MacOSCheckbox");
        }
    }
}