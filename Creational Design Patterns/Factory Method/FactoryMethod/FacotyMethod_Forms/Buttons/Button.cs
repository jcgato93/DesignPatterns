using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotyMethod_Forms.Buttons
{
    public interface IButton
    {
        void render();
        void onClick();
    }
}
