using FacotyMethod_Forms.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacotyMethod_Forms
{
    public partial class Form1 : Form
    {
        private static Dialog dialog;

        public Form1()
        {
            InitializeComponent();

            // configuracion de controles segun el entorno
            configure();

            // Lanza la interfaz previamente configurada
            runBusinessLogic();
        }


        /*
         * La fabrica concreta usualmente elige dependiendo de la configuracion
         * o las variables de entorno
         */
        static void configure()
        {
            PlatformID os = Environment.OSVersion.Platform;

            if (os == PlatformID.Win32Windows)
            {
                dialog = new WindowsDialog();
            }
            else
            {
                dialog = new HtmlDialog();
            }
        }


        /*
         * Todo el codigo del cliente deberia funcionar con fabricas y productos
         * atraves de * interfaces abstactas. De esta manera no le importa con que fabrica
         * trabaja y que tipo de producto devuelve
         */
        static void runBusinessLogic()
        {
            dialog.renderWindow();
        }
    }
}
