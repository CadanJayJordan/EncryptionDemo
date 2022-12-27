
namespace Encryption {
    partial class frmStartup {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnShift = new System.Windows.Forms.Button();
            this.btnSubstitution = new System.Windows.Forms.Button();
            this.btnTransposition = new System.Windows.Forms.Button();
            this.btnSalt = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShift
            // 
            this.btnShift.Location = new System.Drawing.Point(12, 12);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(81, 39);
            this.btnShift.TabIndex = 0;
            this.btnShift.Text = "Shift";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnSubstitution
            // 
            this.btnSubstitution.Location = new System.Drawing.Point(186, 12);
            this.btnSubstitution.Name = "btnSubstitution";
            this.btnSubstitution.Size = new System.Drawing.Size(81, 39);
            this.btnSubstitution.TabIndex = 1;
            this.btnSubstitution.Text = "Substitution";
            this.btnSubstitution.UseVisualStyleBackColor = true;
            this.btnSubstitution.Click += new System.EventHandler(this.btnSubstitution_Click);
            // 
            // btnTransposition
            // 
            this.btnTransposition.Location = new System.Drawing.Point(99, 12);
            this.btnTransposition.Name = "btnTransposition";
            this.btnTransposition.Size = new System.Drawing.Size(81, 39);
            this.btnTransposition.TabIndex = 2;
            this.btnTransposition.Text = "Transposition";
            this.btnTransposition.UseVisualStyleBackColor = true;
            this.btnTransposition.Click += new System.EventHandler(this.frmTransposition_Click);
            // 
            // btnSalt
            // 
            this.btnSalt.Location = new System.Drawing.Point(273, 12);
            this.btnSalt.Name = "btnSalt";
            this.btnSalt.Size = new System.Drawing.Size(81, 39);
            this.btnSalt.TabIndex = 3;
            this.btnSalt.Text = "Salt";
            this.btnSalt.UseVisualStyleBackColor = true;
            this.btnSalt.Click += new System.EventHandler(this.btnSalt_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.Location = new System.Drawing.Point(360, 12);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(81, 39);
            this.btnRSA.TabIndex = 4;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 67);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnSalt);
            this.Controls.Add(this.btnTransposition);
            this.Controls.Add(this.btnSubstitution);
            this.Controls.Add(this.btnShift);
            this.MaximizeBox = false;
            this.Name = "frmStartup";
            this.Text = "Encyrption - Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnSubstitution;
        private System.Windows.Forms.Button btnTransposition;
        private System.Windows.Forms.Button btnSalt;
        private System.Windows.Forms.Button btnRSA;
    }
}

