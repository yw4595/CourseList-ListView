using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Author: Yanzhi Wang
 * Purpose: This class provides functionality for managing courses and their reviews.
 * Restrictions: This class is designed for use in a Windows Forms application and may not work properly in other contexts.
 */

namespace PE19
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
            Application.Run(new Form1());
        }
    }
}
