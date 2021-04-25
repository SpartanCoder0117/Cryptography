using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Program7_Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_File_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label2.Text = "File selected";
                    label3.Text = "";
                    MessageBox.Show("File selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    label3.Text = "File no selected";
                    label2.Text = "";
                }

            }catch(Exception)
            {
                MessageBox.Show("File no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bt_Sha_Click(object sender, EventArgs e)
        {
            try
            {
                string inPath = openFileDialog1.FileName;
                string ouPath = @"..\..\..\M_Hash.txt";
                string aux, aux2;
                string line = File.ReadAllText(inPath);
                SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
                sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(line));
                byte[] ans = sha.Hash;
                StringBuilder builder = new StringBuilder();
                foreach (byte bt in ans)
                {
                    builder.Append(bt.ToString("x2"));
                }
                aux = builder.ToString();
                aux2 = line + "\n";
                File.WriteAllText(ouPath, aux2 + aux);
                MessageBox.Show("SHA-1 generated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Error while generating the hash", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bt_file2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    label4.Text = "File selected";
                    label5.Text = "";
                    MessageBox.Show("File selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    label5.Text = "File no selected";
                    label4.Text = "";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("File no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bt_integrity_Click(object sender, EventArgs e)
        {
            try
            {
                string inPath = openFileDialog2.FileName;
                string outPath = @"..\..\..\Temp_Plain.txt";
                string outPath2 = @"..\..\..\Temp_Sha.txt";
                string aux;
                StreamReader reader = new StreamReader(inPath, Encoding.UTF8, false);
                string line = reader.ReadToEnd();
                string plain_text = line.Substring(0, line.Length - 41);
                string sha = line.Substring(line.Length - 40);


                SHA1CryptoServiceProvider sha2 = new SHA1CryptoServiceProvider();
                sha2.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plain_text));
                byte[] ans = sha2.Hash;
                StringBuilder builder = new StringBuilder();
                foreach (byte bt in ans)
                {
                    builder.Append(bt.ToString("x2"));
                }
                aux = builder.ToString();
                File.WriteAllText(outPath, plain_text);
                File.WriteAllText(outPath2, sha);
                if (sha == aux)
                    MessageBox.Show("The message is complete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("The message is not complete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reader.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error when comparing the hash", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
