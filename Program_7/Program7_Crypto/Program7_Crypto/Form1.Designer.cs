namespace Program7_Crypto
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
            this.Bt_Sha = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_integrity = new System.Windows.Forms.Button();
            this.Bt_file2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_File
            // 
            this.Bt_File.Location = new System.Drawing.Point(31, 55);
            this.Bt_File.Name = "Bt_File";
            this.Bt_File.Size = new System.Drawing.Size(75, 23);
            this.Bt_File.TabIndex = 0;
            this.Bt_File.Text = "Select file";
            this.Bt_File.UseVisualStyleBackColor = true;
            this.Bt_File.Click += new System.EventHandler(this.Bt_File_Click);
            // 
            // Bt_Sha
            // 
            this.Bt_Sha.Location = new System.Drawing.Point(213, 55);
            this.Bt_Sha.Name = "Bt_Sha";
            this.Bt_Sha.Size = new System.Drawing.Size(75, 23);
            this.Bt_Sha.TabIndex = 1;
            this.Bt_Sha.Text = "Execute";
            this.Bt_Sha.UseVisualStyleBackColor = true;
            this.Bt_Sha.Click += new System.EventHandler(this.Bt_Sha_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "SHA - 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(112, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 15);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(112, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 15);
            this.label3.TabIndex = 4;
            // 
            // Bt_integrity
            // 
            this.Bt_integrity.AutoSize = true;
            this.Bt_integrity.Location = new System.Drawing.Point(213, 126);
            this.Bt_integrity.Name = "Bt_integrity";
            this.Bt_integrity.Size = new System.Drawing.Size(79, 23);
            this.Bt_integrity.TabIndex = 5;
            this.Bt_integrity.Text = "Data integrity";
            this.Bt_integrity.UseVisualStyleBackColor = true;
            this.Bt_integrity.Click += new System.EventHandler(this.Bt_integrity_Click);
            // 
            // Bt_file2
            // 
            this.Bt_file2.Location = new System.Drawing.Point(31, 126);
            this.Bt_file2.Name = "Bt_file2";
            this.Bt_file2.Size = new System.Drawing.Size(75, 23);
            this.Bt_file2.TabIndex = 6;
            this.Bt_file2.Text = "Select file ";
            this.Bt_file2.UseVisualStyleBackColor = true;
            this.Bt_file2.Click += new System.EventHandler(this.Bt_file2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(112, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 15);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(112, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 15);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Integrity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 180);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bt_file2);
            this.Controls.Add(this.Bt_integrity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_Sha);
            this.Controls.Add(this.Bt_File);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SHA - 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_File;
        private System.Windows.Forms.Button Bt_Sha;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_integrity;
        private System.Windows.Forms.Button Bt_file2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

