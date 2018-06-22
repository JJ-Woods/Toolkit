using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.IO.Ports;

namespace BluetoothTools{

    public class BTToolsControl{

        
        public void playWithBT() {

            using (SerialPort inPort = new SerialPort("COM1", 9600)) {
                
                inPort.WriteLine("Hello!");
            }
            
        }
    }
}
