using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacotyMethod_Forms.Buttons;

namespace FacotyMethod_Forms.Factory
{
    public class WindowsDialog : Dialog
    {
        public override IButton createButton()
        {
            return new HtmlButton();
        }
    }
}
