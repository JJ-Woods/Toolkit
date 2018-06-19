using System;
using System.Collections.Generic;
using System.Threading;

namespace Pro42
{
    public class Control
    {
        public void startInstall() 
        {
            string name = "MyAlignerInstallmMutexToEnsureThatOnlyASingleInstanceIsRunning";
            try 
            {
                Mutex.OpenExisting(name);
                Environment.Exit(0);
            } 
            catch
            {
                Mutex mutex = new Mutex(true, name);
            }
            new MessageAndProgressBar().ShowDialog();
        }
    }
}
