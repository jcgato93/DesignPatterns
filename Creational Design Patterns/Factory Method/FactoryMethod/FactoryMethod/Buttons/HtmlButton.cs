using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Buttons
{
    public class HtmlButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("Click! Button Says - 'Hello world!'");
        }

        public void render()
        {
            Console.WriteLine("<button>Test Button</button>");
            onClick();
        }
    }
}
