using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotyMethod_Forms.Buttons
{
    public class WindowsButton : IButton
    {
        System.Windows.Forms.Form form = new System.Windows.Forms.Form();
        System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
        System.Windows.Forms.Button button;


        public void onClick()
        {
            this.button = new System.Windows.Forms.Button();
            button.Click += Button_Click;
        }

    

        public void render()
        {
            this.form.AllowDrop = false;
            this.form.Container.Add(this.panel);
            this.form.Container.Add(this.button);

            onClick();
        }



        private void Button_Click(object sender, EventArgs e)
        {
            // Do something .....
        }
    }
}
