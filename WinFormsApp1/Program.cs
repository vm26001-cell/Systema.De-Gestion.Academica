using System;
using System.Windows.Forms;

namespace Systema.De_Gestion.Academica.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAsistencia());
        }
    }
}