using AbstractFactory.App.Buttons;
using AbstractFactory.App.Checkbox;

namespace AbstractFactory.App.Factories
{
    public class MacOSFactory : GUIFactory
    {
        public IButton createButton()
        {
            return new MacOSButton();
        }

        public ICheckbox createCheckbox()
        {
            return new MacOSCheckbox();
        }
    }
}