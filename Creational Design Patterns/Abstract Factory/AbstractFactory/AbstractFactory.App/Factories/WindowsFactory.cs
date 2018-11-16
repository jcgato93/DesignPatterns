using AbstractFactory.App.Buttons;
using AbstractFactory.App.Checkbox;

namespace AbstractFactory.App.Factories
{
    public class WindowsFactory : GUIFactory
    {
        public IButton createButton()
        {
            return new WindowsButton();
        }

        public ICheckbox createCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}