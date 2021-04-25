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
using System.Xml.Serialization;
using System.IO;

namespace Program6_Crypto
{
    public partial class Form1 : Form
    {
        /*public static RSAParameters publicKey;
        public static RSAParameters privateKey;*/
        string outPublicKey = @"..\..\keys\Public.key";
        string outPrivateKey = @"..\..\keys\Private.key";
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
                    label4.Text = "File selected";
                    label5.Text = "";
                }
                else
                {
                    label5.Text = "File no selected";
                    label4.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("File no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bt_Key_Click(object sender, EventArgs e)
        {
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                rsa.PersistKeyInCsp = false;
                if (File.Exists(outPublicKey))
                    File.Delete(outPublicKey);
                if (File.Exists(outPrivateKey))
                    File.Delete(outPrivateKey);
                string publicKey = rsa.ToXmlString(false);
                File.WriteAllText(outPublicKey, publicKey);
                string privateKey = rsa.ToXmlString(true);
                File.WriteAllText(outPrivateKey, privateKey);
            }
            MessageBox.Show("Generated keys", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Bt_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string inPath = openFileDialog1.FileName;
                string outPath = @"..\..\Encrypt.txt";
                string keyPB;
                string aux = File.ReadAllText(inPath);
                byte[] encrypted;
                byte[] original = Encoding.UTF8.GetBytes(aux);
                using (var rsa = new RSACryptoServiceProvider(1024))
                {
                    rsa.PersistKeyInCsp = false;
                    keyPB = File.ReadAllText(openFileDialog2.FileName);
                    rsa.FromXmlString(keyPB);
                    encrypted = rsa.Encrypt(original, true);
                }
                File.WriteAllText(outPath, BitConverter.ToString(encrypted));
                //File.WriteAllText(outPath, Encoding.UTF8.GetBytes(BitConverter.ToString(encrypted)));
                MessageBox.Show("Encrypted file", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("You have exceeded the length", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string inPath = openFileDialog1.FileName;
                string outPath = @"..\..\Decrypt.txt";
                string keyPV;
                string line = File.ReadAllText(inPath);
                byte[] encrypted = FromHex(line);
                byte[] decrypted;

                using (var rsa = new RSACryptoServiceProvider(1024))
                {
                    rsa.PersistKeyInCsp = false;
                    keyPV = File.ReadAllText(openFileDialog3.FileName);
                    rsa.FromXmlString(keyPV);
                    decrypted = rsa.Decrypt(encrypted, true);
                }
                File.WriteAllText(outPath, Encoding.UTF8.GetString(decrypted));
                MessageBox.Show("Decrypted file", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("You have exceeded the length", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Convert byte array hex to string
        /// </summary>
        /// <param name="hex">byte array hex</param>
        /// <returns>string</returns>
        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        private void Bt_PB_Click(object sender, EventArgs e)
        {
            if(openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Selected public key", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Bt_PV_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Selected private key", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
