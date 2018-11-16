using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Buttons
{
    public interface IButton
    {
        void render();
        void onClick();
    }
}
