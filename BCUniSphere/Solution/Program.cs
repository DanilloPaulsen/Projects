using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tiaan Theron - 577856
// Tiaan Kritzinger - 577643
// Dérik Janse van Rensburg - 577184
// Danillo Paulsen - 577735

namespace BCUniSphere
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginIn());
        }
    }
}
