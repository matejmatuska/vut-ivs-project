using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVS_GUI
{
    public class Controller : GuiKalk
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        /// 
        GuiKalk gui = new GuiKalk();
        [STAThread]
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GuiKalk());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            gui.Outcome.Text = "Text";

        }

    }
}
