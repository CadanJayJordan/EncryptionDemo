
namespace Encryption.Forms.Encryption {
    partial class frmRSA {
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.nudPrime1 = new System.Windows.Forms.NumericUpDown();
            this.nudPrime2 = new System.Windows.Forms.NumericUpDown();
            this.nudExponent = new System.Windows.Forms.NumericUpDown();
            this.lblPrime1 = new System.Windows.Forms.Label();
            this.lblPrime2 = new System.Windows.Forms.Label();
            this.lblExponent = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(193, 20);
            this.txtInput.TabIndex = 0;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(12, 38);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(193, 20);
            this.txtPublicKey.TabIndex = 1;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(12, 64);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(193, 20);
            this.txtPrivateKey.TabIndex = 2;
            // 
            // nudPrime1
            // 
            this.nudPrime1.Location = new System.Drawing.Point(276, 13);
            this.nudPrime1.Name = "nudPrime1";
            this.nudPrime1.Size = new System.Drawing.Size(48, 20);
            this.nudPrime1.TabIndex = 3;
            // 
            // nudPrime2
            // 
            this.nudPrime2.Location = new System.Drawing.Point(276, 39);
            this.nudPrime2.Name = "nudPrime2";
            this.nudPrime2.Size = new System.Drawing.Size(48, 20);
            this.nudPrime2.TabIndex = 4;
            // 
            // nudExponent
            // 
            this.nudExponent.Location = new System.Drawing.Point(276, 65);
            this.nudExponent.Name = "nudExponent";
            this.nudExponent.Size = new System.Drawing.Size(48, 20);
            this.nudExponent.TabIndex = 5;
            // 
            // lblPrime1
            // 
            this.lblPrime1.AutoSize = true;
            this.lblPrime1.Location = new System.Drawing.Point(225, 15);
            this.lblPrime1.Name = "lblPrime1";
            this.lblPrime1.Size = new System.Drawing.Size(45, 13);
            this.lblPrime1.TabIndex = 6;
            this.lblPrime1.Text = "Prime 1:";
            // 
            // lblPrime2
            // 
            this.lblPrime2.AutoSize = true;
            this.lblPrime2.Location = new System.Drawing.Point(225, 41);
            this.lblPrime2.Name = "lblPrime2";
            this.lblPrime2.Size = new System.Drawing.Size(45, 13);
            this.lblPrime2.TabIndex = 7;
            this.lblPrime2.Text = "Prime 2:";
            // 
            // lblExponent
            // 
            this.lblExponent.AutoSize = true;
            this.lblExponent.Location = new System.Drawing.Point(215, 67);
            this.lblExponent.Name = "lblExponent";
            this.lblExponent.Size = new System.Drawing.Size(55, 13);
            this.lblExponent.TabIndex = 8;
            this.lblExponent.Text = "Exponent:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 92);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(93, 92);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // frmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 127);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblExponent);
            this.Controls.Add(this.lblPrime2);
            this.Controls.Add(this.lblPrime1);
            this.Controls.Add(this.nudExponent);
            this.Controls.Add(this.nudPrime2);
            this.Controls.Add(this.nudPrime1);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.txtInput);
            this.Name = "frmRSA";
            this.Text = "frmRSA";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.NumericUpDown nudPrime1;
        private System.Windows.Forms.NumericUpDown nudPrime2;
        private System.Windows.Forms.NumericUpDown nudExponent;
        private System.Windows.Forms.Label lblPrime1;
        private System.Windows.Forms.Label lblPrime2;
        private System.Windows.Forms.Label lblExponent;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}