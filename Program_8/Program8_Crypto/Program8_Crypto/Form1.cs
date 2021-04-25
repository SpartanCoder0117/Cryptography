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
using System.Xml.Serialization;

namespace Program8_Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cb_Conf.Checked == true)
                {
                    if (Rad_AES.Checked == true)
                    {
                        string outPath = @"..\..\..\M_DecryptAES.txt";
                        string inPath = openFileDialog1.FileName;
                        string key = openFileDialog2.FileName;

                        string k = RSA_Key(key);
                        string decrypt = DecryptAES_Func(inPath, k);

                        File.WriteAllText(outPath, decrypt);
                    }
                    else if (Rad_DES.Checked == true)
                    {
                        string outPath = @"..\..\..\M_DecryptDES.txt";
                        string datos = openFileDialog1.FileName;
                        string key2 = openFileDialog2.FileName;

                        string k2 = RSA_Key(key2);
                        string decryptDES = DecryptDES_Func(datos, k2);

                        File.WriteAllText(outPath, decryptDES);
                    }
                }
                else if (Cb_Inte.Checked == true)
                {
                    if (Rad_AES.Checked == true || Rad_DES.Checked == true)
                    {
                        string inPath = openFileDialog1.FileName;
                        string inKey = openFileDialog2.FileName;

                        StreamReader reader = new StreamReader(inKey, Encoding.UTF8, false);
                        string line = reader.ReadToEnd();
                        Console.WriteLine(line);
                        string sh = SHA_1(inPath);
                        Console.WriteLine(sh);
                        if (line == sh)
                            MessageBox.Show("The message is complete :D", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("The message is not complete :'(", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error to decrypt", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Bt_File_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("File selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("File no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception)
            {
                MessageBox.Show("File no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bt_Key_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("Key selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Key no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception)
            {
                MessageBox.Show("Key no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bt_Private_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog3.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("Private key selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Private key no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Private key no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bt_Public_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog4.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("Public key selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Public key no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Public no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string RSA_Key(string k)
        {
            string keyPV;
            string line = File.ReadAllText(k);
            byte[] encrypted = FromHex(line);
            byte[] decrypted;
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                rsa.PersistKeyInCsp = false;
                keyPV = File.ReadAllText(openFileDialog3.FileName);
                rsa.FromXmlString(keyPV);
                decrypted = rsa.Decrypt(encrypted, true);
            }
            string outd = Encoding.UTF8.GetString(decrypted);
            return outd;
        }

        private string RSA_SHA(string sh)
        {
            string keyPB;
            string line = File.ReadAllText(sh);
            byte[] encrypted = FromHex(line);
            byte[] decrypted;
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                rsa.PersistKeyInCsp = false;
                keyPB = File.ReadAllText(openFileDialog4.FileName);
                rsa.FromXmlString(keyPB);
                decrypted = rsa.Decrypt(encrypted, true);
            }
            string outd2 = Encoding.UTF8.GetString(decrypted);
            return outd2;
        }

        private string SHA_1(string a)
        {
            string line = File.ReadAllText(a);
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            sha.ComputeHash(UTF8Encoding.UTF8.GetBytes(line));
            byte[] ans = sha.Hash;
            StringBuilder builder = new StringBuilder();
            foreach (byte bt in ans)
            {
                builder.Append(bt.ToString("x2"));
            }
            string aux = builder.ToString();
            return aux;
        }

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

        private string DecryptAES_Func(string inP, string k2)
        {
            string line;

            RijndaelManaged objrij = new RijndaelManaged();
            objrij.Mode = CipherMode.ECB;
            objrij.Padding = PaddingMode.PKCS7;
            objrij.KeySize = 0x80;
            objrij.BlockSize = 0x80;

            line = File.ReadAllText(inP);
            //line2 = File.ReadAllText(k2);

            byte[] encryptedTextByte = Convert.FromBase64String(line);
            byte[] passBytes = Encoding.UTF8.GetBytes(k2);
            byte[] EncryptionkeyBytes = new byte[0x10];
            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);
            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;
            byte[] TextByte = objrij.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
            string decripted = Encoding.UTF8.GetString(TextByte);  //it will return readable stri

            return decripted;
        }

        private string DecryptDES_Func(string datos, string key2)
        {
            string line;
            line = File.ReadAllText(datos);
            //line2 = File.ReadAllText(key2);
            byte[] key = { };// Key 
            byte[] IV = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            byte[] inputByteArray = new byte[line.Length];

            key = Encoding.UTF8.GetBytes(key2);
            DESCryptoServiceProvider ObjDES = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(line);

            MemoryStream Objmst = new MemoryStream();
            CryptoStream Objcs = new CryptoStream(Objmst, ObjDES.CreateDecryptor(key, IV), CryptoStreamMode.Write);
            Objcs.Write(inputByteArray, 0, inputByteArray.Length);
            Objcs.FlushFinalBlock();
            Encoding encoding = Encoding.UTF8;
            string sali = encoding.GetString(Objmst.ToArray());

            return sali;
        }

        private void Cb_Auth_CheckedChanged(object sender, EventArgs e)
        {
            Cb_Inte.Checked = false;
            Cb_Inte.Enabled = !Cb_Inte.Enabled;
        }
    }
}
