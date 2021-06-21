using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPlayerManagementForm
{
    static class ErrorHandling
    {
        /**************************************************************************************/
        /**********************Functions to do with error handling*****************************/
        /**************************************************************************************/

        //Check text for input, display error if no input detected
        public static bool inputDetected(string inputText)
        {
            if (inputText == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Input missing.\nDid you enter all required input?", "Error", buttons, icon);
                return false;
            }
            return true;
        }


        //Check for numeric digits in text
        public static bool isTextNumeric(string inputText)
        {
            bool numeric = int.TryParse(inputText, out _);
            if (!numeric) { return false; }
            return true;
        }


        //Catch exception message
        public static void somethingWentWrongMessage()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show("Something went wrong\nSorry about that!\nConsider checking your input?", "Error", buttons, icon);
        }


        //Data not numeric message
        public static void dataNotNumericMessage(string dataName)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            MessageBox.Show(string.Format("Data in \"{0}\" must be numeric",dataName), "Error", buttons, icon);
        }


        //Data not alphabetical message
        public static void dataNotAlphaMessage(string dataName)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            string message = string.Format("Data in \"{0}\" must be non-numeric", dataName);
            MessageBox.Show(message, "Error", buttons, icon);
        }


        //Generic error message
        public static void genericErrorMessage(string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            MessageBox.Show(message, "Error", buttons, icon);
        }
    }
}
