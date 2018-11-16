using FacotyMethod_Forms.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacotyMethod_Forms.Factory
{
    public abstract class Dialog
    {
        public void renderWindow()
        {
            // ... other code ...

            IButton okButton = createButton();
            okButton.render();
        }

        /*
        * Las subclases deben sobreescribir este metodo y crear el tipo de boton especifico 
        */
        public abstract IButton createButton();
    }
}
