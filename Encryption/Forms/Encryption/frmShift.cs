using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption.Forms.Encryption {
    public partial class frmShift : Form {
        public frmShift() {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e) {
            txtOutput.Text = shiftString(txtInput.Text, Convert.ToInt32(nudShiftAmount.Value)); // set output box to shifted string
        }

        private string shiftString(string stringIn, int shiftAmount) {
            string newString = "";
            foreach (char c in stringIn.ToLower()) { // for every char in string (all lower case)
                newString += shiftChar(c, shiftAmount); // and character to new string
            }
            return newString;
        }

        private char shiftChar(char c, int shiftAmount) {
            int newCInt;

            int start = (int)'a'; // get start of letters as an int
            int end = (int)'z'; // get end of letters as an int

            int cInt = (int)c; // Convert character to int
            newCInt = cInt; // Return this if no shift is taking place to that particular character

            if (cInt >= start && cInt <= end) { // if the character is a letter from a-z
                if((cInt + shiftAmount) > end) { // if shifting will take the character beyond z
                    newCInt = (start + (cInt - end)) + shiftAmount ;
                } else if ((cInt + shiftAmount) < start) { // if shifting wil take the character before a
                    newCInt = (end + (cInt - start) + shiftAmount);
                } else { // A normal shift where it does not go beyond the range
                    newCInt = cInt + shiftAmount;
                }
            }
            return (char)newCInt; // return new character
        }

        private void btnSwap_Click(object sender, EventArgs e) { // Swap text boxes for easy swapping
            string txtIn = txtInput.Text;
            txtInput.Text = txtOutput.Text;
            txtOutput.Text = txtIn;
        }
    }
}
