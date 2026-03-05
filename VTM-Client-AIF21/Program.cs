using System;
using System.Windows.Forms;

namespace VTM_Client_AIF21
{
    internal static class Program
    {
        /// <summary>
        /// Haupteinstiegspunkt der Anwendung (MVC-Start).
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // MVC initialisieren
            Model model = new Model();
            Form1 view = new Form1();
            Controller controller = new Controller(model, view);

            Application.Run(view);
        }
    }
}
