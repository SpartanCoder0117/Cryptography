using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3_Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void File_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = "File selected";
                label2.Text = "";
            }
            else
            {
                label2.Text = "File no selected";
                label1.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //textBox1.ClearUndo();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            //label5.Text = "";
        }

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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        public int euclides(int a)
        {
            int res = 0;
            int c = 256;
            while (c != 0)
            {
                res = a % c;
                a = c;
                c = res;
            }
            return a;
        }

        public int euclidesExtend(int a)
        {
            int x = 0, y = 0, b = 256;
            int x2 = 1, x1 = 0, y2 = 0, y1 = 1;
            int q = 0, r = 0;
            while(b > 0)
            {
                q = (a / b);
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;
            }
            if (x2 < 0)
                x2 = 256 + x2;
            return x2;
        }

        public int invB(int b)
        {
            b = b % 256;
            int inv = 256 - b;
            return inv;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text); //Convierte en entero el contenido del textbox
            int b = Convert.ToInt32(textBox2.Text);
            int mcd = 0;
            string rutaEnt = openFileDialog1.FileName;
            string rutaSal = @"..\..\Encrypt.txt";

            try
            {
                mcd = euclides(a);

                if (mcd == 1)
                {
                    MessageBox.Show("Correct Alpha", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamReader streamReader = new StreamReader(rutaEnt);
                    StreamWriter streamWriter = new StreamWriter(rutaSal);
                   
                    string line = streamReader.ReadToEnd();

                    foreach (Char c in line)
                    {
                        int caracter = Convert.ToInt32(c);
                        int ascii = (a * caracter + b) % 256;
                        streamWriter.Write((char)ascii);
                        //streamWriter.Write((char)(System.Convert.ToInt32(c)));
                    }
                    streamWriter.Close();
                    streamReader.Close();
                    this.textBox3.Text = System.IO.File.ReadAllText(@"..\..\Encrypt.txt");
                }
                else
                {
                    MessageBox.Show("Incorrect Alpha, enter a valid alpha", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File no selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label2.Text = "File no selected";
                label1.Text = "";
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int inva = euclidesExtend(a);
            int invb = invB(b);
            string rutaEnt = @"..\..\Encrypt.txt";
            string rutaSal = @"..\..\Decrypt.txt";
            StreamReader streamReader = new StreamReader(rutaEnt);
            StreamWriter streamWriter = new StreamWriter(rutaSal);

            string line = streamReader.ReadToEnd();
            foreach( Char c in line)
            {
                int caracter = Convert.ToInt32(c);
                int ascii = inva * (caracter + invb) % 256;
                streamWriter.Write((char)ascii);
            }
            streamWriter.Close();
            streamReader.Close();
            this.textBox4.Text = System.IO.File.ReadAllText(@"..\..\Decrypt.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // try
            //{
             /*   int a = Convert.ToInt32(textBox1.Text);
                int mcd = 0;
                mcd = euclides(a);
                if (mcd == 1)
                {
                    MessageBox.Show("Correct Alpha", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong Alpha", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }*/
            //}
            //catch(Exception)
            //{
                //MessageBox.Show("Wrong Alpha", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
