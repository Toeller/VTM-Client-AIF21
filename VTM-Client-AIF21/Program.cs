using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTM_Client_AIF21
{
    internal static class Program
    {
        private IModel model;
        private IView view;
        private IController controller; 
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // MVC initialisieren
            model = new Model();
            view = new Form1();
            controller = new Controller();

            model.View=view;
            model.Controller=controller;
            

            Application.Run(view);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
