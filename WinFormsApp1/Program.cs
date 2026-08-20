using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Systema.De_Gestion.Academica.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new De_Gestion.Academica.UI.FrmLogin());
        }
    }
}