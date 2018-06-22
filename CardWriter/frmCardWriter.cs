using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CardWriter
{

    public partial class frmCardWriter : Form
    {

        private crControl controlObj;


        public frmCardWriter()
        {
            InitializeComponent();

            string[] options = getOptionFolders();

            //Display the options in the combo box
            foreach (string option in options)
            {
                cmbCardOptions.Items.Add(option);
            }

            this.controlObj = new crControl();
        }


        //Get the names of the folders which are the possible updates
        private string[] getOptionFolders()
        {
            const string optionLocation = @"Install\CardWriter\";
            int pathLength = optionLocation.Length;

            string[] optionFolders = Directory.GetDirectories(optionLocation);

            //Get the name not the entire path of the options
            for (int count1 = 0; count1 < optionFolders.Length; count1++)
            {
                string option = optionFolders[count1].Substring(pathLength);
                optionFolders[count1] = option;
            }

            return optionFolders;
        }


        //Write the sd card
        private void btnWriteCard_Click(object sender, EventArgs e)
        {
            string errorCode;

            string selectedOption;

            if (cmbCardOptions.SelectedItem != null)
            {
                selectedOption = cmbCardOptions.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please chose an option to write to card");
                return;
            }

            if (controlObj.updateControl(selectedOption, out errorCode))
            {
                MessageBox.Show("Card complete!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Card write failed!\n" + errorCode);
            }
        }
    }
}
