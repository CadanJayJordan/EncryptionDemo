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
    public partial class frmSalt : Form {
        public frmSalt() {
            InitializeComponent();
        }

        private String encryptString(string inputString, int seed) {
            String newString = ""; // New String to return
            // Declaring new values
            char newChar;
            int ranNum;

            Random ranD = new Random(seed); // Creating a randomizer with the given seed

            foreach (char c in inputString) { // For evey character in the string
                ranNum = Convert.ToInt32((128D * ranD.NextDouble()) + 40D); // Random number is 128*(0-1)+40 meaning a random number is created between 40 to 168
                newChar = Convert.ToChar((int)c ^ ranNum); // XOR The given char to the random number
                newString += newChar; // Add new characer to return string
            }

            return newString; // return string
        }

        private void btnEncrypt_Click(object sender, EventArgs e) {
            txtOutput.Text = encryptString(txtInput.Text, Convert.ToInt32(nudSeed.Value)); // Set output txt box to the return string. Input text and seed value passed into function.
        }

        private void btnSwap_Click(object sender, EventArgs e) { // Swaps two boxes values
            string temp = txtInput.Text;
            txtInput.Text = txtOutput.Text;
            txtOutput.Text = temp;
        }

        private void btnClear_Click(object sender, EventArgs e) { // clears output box
            txtOutput.Text = "";
        }
    }
}
