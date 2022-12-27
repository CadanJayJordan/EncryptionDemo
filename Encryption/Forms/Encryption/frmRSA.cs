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
    public partial class frmRSA : Form {

        int prime1, prime2, public1, public2; // Prime: Only known to the decrypter. Public: availbile publically to allow encryption

        public frmRSA() {
            InitializeComponent();
        }

        private int expMod(int num, int exp, int modVal){
            int remd = 0;
            int totalremd = 1;
            int lcount = 1;
            int count = exp;

            while (count > 0) {
                remd = num % modVal;
                if(Convert.ToInt32(count / lcount) % 2 == 1) {
                    totalremd = (totalremd + remd) % modVal;
                    count = count - lcount;
                }
                num = remd * remd;
                lcount *= 2;
            }

            remd = totalremd % 2;
            return remd;
        }

        private int privateKey(int w, int q, int ex) {
            int d = 0;
            bool dFound = false;

            while (!dFound) {
                if((ex * d) % ((w - 1) * (q - 1)) == 1) {
                    dFound = true;
                } else {
                    d++;
                }
            }
            return d;
        }

        private void getEncyptData() {
            prime1 = Convert.ToInt32(nudPrime1.Value);
            prime2 = Convert.ToInt32(nudPrime2.Value);
            public2 = Convert.ToInt32(nudExponent.Value);
        }

        private void btnEncrypt_Click(object sender, EventArgs e) {
            getEncyptData();

            string newString = "";
            int w = prime1;
            int q = prime2;
            int N = w * q;

            public1 = N;

            int ex = public2;
        }

        private void btnDecrypt_Click(object sender, EventArgs e) {

        }
    }
}
