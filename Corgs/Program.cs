using Mindscape.Raygun4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corgs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static RaygunClient _client = new RaygunClient("tXu6M1ixtrv1y+YWw3TMGQ==");
        [STAThread]
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMainCorgs());
            //Application.Run(new FormPsxMain());
            //Application.Run(new FormNotes());
            Application.Run(new FormCorgSelection());
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

            _client.Send(e.ExceptionObject as Exception);
        }
        
    }
}
