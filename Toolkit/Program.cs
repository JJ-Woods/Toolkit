using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Toolkit {

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            checkNET();

            try 
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMainWindow());
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        //Check the version of .net and update to 2.0 if required
        private static void checkNET() 
        {

        }


        //Run a new thread
        public static void newThread(ref Thread thr, string threadName) 
        {
            thr.IsBackground = false;
            thr.Name = threadName;
            thr.Start();
        }


        //Open a new menu object
        public static void openNewMenu(Form newForm, Form currentForm, string menuName)
        {
            Thread menuUI = new Thread(() => Application.Run(newForm));
            newThread(ref menuUI, menuName);
            currentForm.Close();
            
        }


        //Run the selected form in a new dialog box
        public static void runNewWindow(Form newForm)
        {
            newForm.ShowDialog();
        }
    }
}
