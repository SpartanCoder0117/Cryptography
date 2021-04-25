namespace Program6_Crypto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bt_Key = new System.Windows.Forms.Button();
            this.Bt_Encrypt = new System.Windows.Forms.Button();
            this.Bt_Decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_File = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bt_PB = new System.Windows.Forms.Button();
            this.Bt_PV = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_Key
            // 
            this.Bt_Key.AutoSize = true;
            this.Bt_Key.Location = new System.Drawing.Point(158, 99);
            this.Bt_Key.Name = "Bt_Key";
            this.Bt_Key.Size = new System.Drawing.Size(83, 23);
            this.Bt_Key.TabIndex = 0;
            this.Bt_Key.Text = "Key generator";
            this.Bt_Key.UseVisualStyleBackColor = true;
            this.Bt_Key.Click += new System.EventHandler(this.Bt_Key_Click);
            // 
            // Bt_Encrypt
            // 
            this.Bt_Encrypt.Location = new System.Drawing.Point(59, 220);
            this.Bt_Encrypt.Name = "Bt_Encrypt";
            this.Bt_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Bt_Encrypt.TabIndex = 1;
            this.Bt_Encrypt.Text = "Encrypt";
            this.Bt_Encrypt.UseVisualStyleBackColor = true;
            this.Bt_Encrypt.Click += new System.EventHandler(this.Bt_Encrypt_Click);
            // 
            // Bt_Decrypt
            // 
            this.Bt_Decrypt.Location = new System.Drawing.Point(259, 220);
            this.Bt_Decrypt.Name = "Bt_Decrypt";
            this.Bt_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Bt_Decrypt.TabIndex = 2;
            this.Bt_Decrypt.Text = "Decrypt";
            this.Bt_Decrypt.UseVisualStyleBackColor = true;
            this.Bt_Decrypt.Click += new System.EventHandler(this.Bt_Decrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "RSA Cipher";
            // 
            // Bt_File
            // 
            this.Bt_File.Location = new System.Drawing.Point(27, 57);
            this.Bt_File.Name = "Bt_File";
            this.Bt_File.Size = new System.Drawing.Size(75, 23);
            this.Bt_File.TabIndex = 8;
            this.Bt_File.Text = "File";
            this.Bt_File.UseVisualStyleBackColor = true;
            this.Bt_File.Click += new System.EventHandler(this.Bt_File_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(109, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 15);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(109, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 15);
            this.label5.TabIndex = 10;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Bt_PB
            // 
            this.Bt_PB.Location = new System.Drawing.Point(59, 156);
            this.Bt_PB.Name = "Bt_PB";
            this.Bt_PB.Size = new System.Drawing.Size(75, 23);
            this.Bt_PB.TabIndex = 11;
            this.Bt_PB.Text = "Public Key";
            this.Bt_PB.UseVisualStyleBackColor = true;
            this.Bt_PB.Click += new System.EventHandler(this.Bt_PB_Click);
            // 
            // Bt_PV
            // 
            this.Bt_PV.Location = new System.Drawing.Point(259, 156);
            this.Bt_PV.Name = "Bt_PV";
            this.Bt_PV.Size = new System.Drawing.Size(75, 23);
            this.Bt_PV.TabIndex = 12;
            this.Bt_PV.Text = "Private Key";
            this.Bt_PV.UseVisualStyleBackColor = true;
            this.Bt_PV.Click += new System.EventHandler(this.Bt_PV_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select the public key to encrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select the private key to decrypt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bt_PV);
            this.Controls.Add(this.Bt_PB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bt_File);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_Decrypt);
            this.Controls.Add(this.Bt_Encrypt);
            this.Controls.Add(this.Bt_Key);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Key;
        private System.Windows.Forms.Button Bt_Encrypt;
        private System.Windows.Forms.Button Bt_Decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_File;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bt_PB;
        private System.Windows.Forms.Button Bt_PV;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

