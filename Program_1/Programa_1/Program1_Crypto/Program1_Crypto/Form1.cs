using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Program1_Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Selected the file to encrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }         
        }

        /// <summary>
        /// This button works to open the file that you want to encrypt
        /// </summary>
        /// <param name="sender">none</param>
        /// <param name="e">none</param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = "File selected";
                label6.Text = "";
            }
            else
            {
                label6.Text = "File no selected";
                label1.Text = "";
            }
        }

        /// <summary>
        /// This button encrypt the selected file by converting the data into
        /// integer and adding the value received in the textbox and deciphering the inverse sum
        /// </summary>
        /// <param name="sender">none</param>
        /// <param name="e">none</param>
        private void button1_Click(object sender, EventArgs e)
        {
            //converts the data received from the text box to an integer.
            int key = Convert.ToInt32(textBox1.Text); 
            string rutaEnt = openFileDialog1.FileName;
            string rutaSal = @"..\..\Encrypt.txt";
            //the outflow for the encrypted file is created
            FileStream fs = File.Create(rutaSal);
            //Flows are created for the use of the input and output file
            StreamReader streamReader = new StreamReader(rutaEnt);
            StreamWriter streamWriter = new StreamWriter(fs);
            //In case the key exceeds 256 the module is obtained
            int resk = key % 256;
            try
            {
                if (key <= 256)
                {
                    label5.Text = "";
                    //read the file to the end
                    string line = streamReader.ReadToEnd();
                    //for each character in the file it becomes an integer and adds the 
                    //data obtained in the textbox
                    foreach (Char c in line)
                    {
                        streamWriter.Write((char)(System.Convert.ToInt32(c) + key));
                    }
                }
                else
                {
                    //if it exceeds 256, an adjustment is made
                    label5.Text = "exceed the range, adjust to " + resk;
                    string line = streamReader.ReadToEnd();
                    foreach (Char c in line)
                    {
                        streamWriter.Write((char)(System.Convert.ToInt32(c) + resk));
                    }
                }
                //we close the flows
                streamWriter.Close();
                streamReader.Close();
                //create a text file with the encrypted string
                this.textBox2.Text = System.IO.File.ReadAllText(@"..\..\Encrypt.txt");
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("File no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label6.Text = "File no selected";
                label1.Text = "";
            }
                
        }

        /// <summary>
        /// if the key is less than 256, the value obtained in the textbox
        /// must be subtracted and if it is higher, its inverse is added
        /// </summary>
        /// <param name="sender">none</param>
        /// <param name="e">none</param>
        private void button2_Click(object sender, EventArgs e)
        {
            //converts the data received from the text box to an integer.
            int key = Convert.ToInt32(textBox1.Text);
            int comp1 = (256 - key) % 256;
            string rutaEnt = @"..\..\Encrypt.txt";
            string rutaSal = @"..\..\Decrypt.txt";
            //the outflow for the decrypted file is created
            FileStream fs = File.Create(rutaSal);
            //Flows are created for the use of the input and output file
            StreamReader streamReader = new StreamReader(rutaEnt);
            StreamWriter streamWriter = new StreamWriter(fs);

            if (key <= 256)
            {
                label5.Text = "";
                //read the file to the end
                string line = streamReader.ReadToEnd();
                //for each character in the file it becomes an integer and adds the 
                //data obtained in the textbox
                foreach (Char c in line)
                {
                    streamWriter.Write((char)(System.Convert.ToInt32(c) - key));
                }
            }
            else
            {
                //if it exceeds 256, an adjustment is made
                label5.Text = "exceed the range, adjust to " + comp1;
                string line = streamReader.ReadToEnd();
                foreach (Char c in line)
                {
                    streamWriter.Write((char)(System.Convert.ToInt32(c) + comp1));
                }
            }
            //we close the flows
            streamWriter.Close();
            streamReader.Close();
            //create a text file with the decrypted string
            this.textBox3.Text = System.IO.File.ReadAllText(@"..\..\Decrypt.txt");
        }

        /// <summary>
        /// cleans all program components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
        }

        /// <summary>
        /// Close the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
