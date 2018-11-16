using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotyMethod_Forms.Buttons
{
    public class HtmlButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("Click! button says - 'Hello world!'");
        }

        public void render()
        {
            Console.WriteLine("<button>Test Button</button>");
            onClick();
        }
    }
}
