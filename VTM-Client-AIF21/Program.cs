using System;
using System.Windows.Forms;
using VTM_Client_AIF21.Models;
using VTM_Client_AIF21.Views;
using VTM_Client_AIF21.Controllers;

namespace VTM_Client_AIF21
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // MVC Initialisierung
            var model = new Model();
            var view = new MainForm();
            var controller = new MainController(model, view);

            Application.Run(view);
        }
    }
}
