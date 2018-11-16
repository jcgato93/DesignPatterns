using AbstractFactory.App.Buttons;
using AbstractFactory.App.Checkbox;
using AbstractFactory.App.Factories;

namespace AbstractFactory.App.app
{
    public class Application
    {
        private IButton button;
        private ICheckbox checkbox;


    public Application(GUIFactory factory)
    {
        button = factory.createButton();
        checkbox = factory.createCheckbox();
    }
    

    public void paint(){
        button.paint();
        checkbox.paint();
    }

    }
}