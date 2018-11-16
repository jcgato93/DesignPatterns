using AbstractFactory.App.Buttons;
using AbstractFactory.App.Checkbox;

namespace AbstractFactory.App.Factories
{
    /*
     * la fabrica abstracta conoce todo sobre los productos abstractos
     */
    public interface GUIFactory
    {
         abstract IButton createButton();
         abstract ICheckbox createCheckbox();
    }
}