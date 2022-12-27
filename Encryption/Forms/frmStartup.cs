using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encryption.Forms.Encryption;

namespace Encryption {
    public partial class frmStartup : Form {
        public frmStartup() {
            InitializeComponent();
        }

        private void btnShift_Click(object sender, EventArgs e) {
            frmShift frmShift = new frmShift();
            this.Hide();
            frmShift.ShowDialog();
            this.Show();
        }

        private void frmTransposition_Click(object sender, EventArgs e) {
            frmTransposition frmTransposition = new frmTransposition();
            this.Hide();
            frmTransposition.ShowDialog();
            this.Show();
        }

        private void btnSubstitution_Click(object sender, EventArgs e) {
            frmSubstitution frmSubstitution = new frmSubstitution();
            this.Hide();
            frmSubstitution.ShowDialog();
            this.Show();
        }

        private void btnRSA_Click(object sender, EventArgs e) {
            frmRSA frmRSA = new frmRSA();
            this.Hide();
            frmRSA.ShowDialog();
            this.Show();
        }

        private void btnSalt_Click(object sender, EventArgs e) {
            frmSalt frmSalt = new frmSalt();
            this.Hide();
            frmSalt.ShowDialog();
            this.Show();
        }
    }
}
