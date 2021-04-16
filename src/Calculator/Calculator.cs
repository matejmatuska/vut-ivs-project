using System;
using System.Windows.Forms;

namespace Calc
{
    public class Controller : GuiKalk
    {
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GuiKalk());
        }

    }
}
