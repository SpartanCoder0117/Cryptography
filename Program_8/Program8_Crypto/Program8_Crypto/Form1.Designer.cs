namespace Program8_Crypto
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
            this.Bt_File = new System.Windows.Forms.Button();
            this.Bt_Decrypt = new System.Windows.Forms.Button();
            this.Rad_AES = new System.Windows.Forms.RadioButton();
            this.Rad_DES = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Bt_Key = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Bt_Private = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cb_Inte = new System.Windows.Forms.CheckBox();
            this.Cb_Conf = new System.Windows.Forms.CheckBox();
            this.Cb_Auth = new System.Windows.Forms.CheckBox();
            this.Bt_Public = new System.Windows.Forms.Button();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_File
            // 
            this.Bt_File.Location = new System.Drawing.Point(40, 12);
            this.Bt_File.Name = "Bt_File";
            this.Bt_File.Size = new System.Drawing.Size(75, 23);
            this.Bt_File.TabIndex = 0;
            this.Bt_File.Text = "Select File";
            this.Bt_File.UseVisualStyleBackColor = true;
            this.Bt_File.Click += new System.EventHandler(this.Bt_File_Click);
            // 
            // Bt_Decrypt
            // 
            this.Bt_Decrypt.Location = new System.Drawing.Point(40, 191);
            this.Bt_Decrypt.Name = "Bt_Decrypt";
            this.Bt_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Bt_Decrypt.TabIndex = 1;
            this.Bt_Decrypt.Text = "Launch";
            this.Bt_Decrypt.UseVisualStyleBackColor = true;
            this.Bt_Decrypt.Click += new System.EventHandler(this.Bt_Decrypt_Click);
            // 
            // Rad_AES
            // 
            this.Rad_AES.AutoSize = true;
            this.Rad_AES.Checked = true;
            this.Rad_AES.Location = new System.Drawing.Point(40, 87);
            this.Rad_AES.Name = "Rad_AES";
            this.Rad_AES.Size = new System.Drawing.Size(46, 17);
            this.Rad_AES.TabIndex = 8;
            this.Rad_AES.TabStop = true;
            this.Rad_AES.Text = "AES";
            this.Rad_AES.UseVisualStyleBackColor = true;
            // 
            // Rad_DES
            // 
            this.Rad_DES.AutoSize = true;
            this.Rad_DES.Location = new System.Drawing.Point(40, 111);
            this.Rad_DES.Name = "Rad_DES";
            this.Rad_DES.Size = new System.Drawing.Size(47, 17);
            this.Rad_DES.TabIndex = 9;
            this.Rad_DES.Text = "DES";
            this.Rad_DES.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bt_Key
            // 
            this.Bt_Key.Location = new System.Drawing.Point(40, 48);
            this.Bt_Key.Name = "Bt_Key";
            this.Bt_Key.Size = new System.Drawing.Size(75, 23);
            this.Bt_Key.TabIndex = 10;
            this.Bt_Key.Text = "Key/Sha1";
            this.Bt_Key.UseVisualStyleBackColor = true;
            this.Bt_Key.Click += new System.EventHandler(this.Bt_Key_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Bt_Private
            // 
            this.Bt_Private.Location = new System.Drawing.Point(197, 191);
            this.Bt_Private.Name = "Bt_Private";
            this.Bt_Private.Size = new System.Drawing.Size(75, 23);
            this.Bt_Private.TabIndex = 11;
            this.Bt_Private.Text = "Private Key";
            this.Bt_Private.UseVisualStyleBackColor = true;
            this.Bt_Private.Click += new System.EventHandler(this.Bt_Private_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cb_Inte);
            this.groupBox1.Controls.Add(this.Cb_Conf);
            this.groupBox1.Controls.Add(this.Cb_Auth);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(158, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 146);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // Cb_Inte
            // 
            this.Cb_Inte.AutoSize = true;
            this.Cb_Inte.Location = new System.Drawing.Point(6, 99);
            this.Cb_Inte.Name = "Cb_Inte";
            this.Cb_Inte.Size = new System.Drawing.Size(137, 28);
            this.Cb_Inte.TabIndex = 19;
            this.Cb_Inte.Text = "Integrity";
            this.Cb_Inte.UseVisualStyleBackColor = true;
            // 
            // Cb_Conf
            // 
            this.Cb_Conf.AutoSize = true;
            this.Cb_Conf.Checked = true;
            this.Cb_Conf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_Conf.Location = new System.Drawing.Point(6, 31);
            this.Cb_Conf.Name = "Cb_Conf";
            this.Cb_Conf.Size = new System.Drawing.Size(209, 28);
            this.Cb_Conf.TabIndex = 17;
            this.Cb_Conf.Text = "Confidentiality";
            this.Cb_Conf.UseVisualStyleBackColor = true;
            // 
            // Cb_Auth
            // 
            this.Cb_Auth.AutoSize = true;
            this.Cb_Auth.Location = new System.Drawing.Point(6, 65);
            this.Cb_Auth.Name = "Cb_Auth";
            this.Cb_Auth.Size = new System.Drawing.Size(173, 28);
            this.Cb_Auth.TabIndex = 18;
            this.Cb_Auth.Text = "Authenticity";
            this.Cb_Auth.UseVisualStyleBackColor = true;
            this.Cb_Auth.CheckedChanged += new System.EventHandler(this.Cb_Auth_CheckedChanged);
            // 
            // Bt_Public
            // 
            this.Bt_Public.Location = new System.Drawing.Point(302, 191);
            this.Bt_Public.Name = "Bt_Public";
            this.Bt_Public.Size = new System.Drawing.Size(75, 23);
            this.Bt_Public.TabIndex = 16;
            this.Bt_Public.Text = "Public key";
            this.Bt_Public.UseVisualStyleBackColor = true;
            this.Bt_Public.Click += new System.EventHandler(this.Bt_Public_Click);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 243);
            this.Controls.Add(this.Bt_Public);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bt_Private);
            this.Controls.Add(this.Bt_Key);
            this.Controls.Add(this.Rad_DES);
            this.Controls.Add(this.Rad_AES);
            this.Controls.Add(this.Bt_Decrypt);
            this.Controls.Add(this.Bt_File);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Decrypt Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_File;
        private System.Windows.Forms.Button Bt_Decrypt;
        private System.Windows.Forms.RadioButton Rad_AES;
        private System.Windows.Forms.RadioButton Rad_DES;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Bt_Key;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button Bt_Private;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_Public;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.CheckBox Cb_Inte;
        private System.Windows.Forms.CheckBox Cb_Conf;
        private System.Windows.Forms.CheckBox Cb_Auth;
    }
}

