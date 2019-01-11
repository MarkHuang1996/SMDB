using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace SMDB
{
    static class Program
    {
        public static Admin CurrentAdmin = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin objFrmLogin = new FrmLogin();
            // using show the login form
            DialogResult result = objFrmLogin.ShowDialog();
            if(result == DialogResult.OK)
            {
                Application.Run(new FrmMain());

            }
            else
            {
                Application.Exit();
            }



          
        }

       
    }
}
