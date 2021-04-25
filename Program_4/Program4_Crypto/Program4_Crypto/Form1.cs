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

namespace Program4_Crypto
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
                string Ruta = openFileDialog1.FileName;
                FileStream fs = new FileStream(Ruta, FileMode.Open, FileAccess.Read);
                pictureBox1.Image = Image.FromStream(fs);
                fs.Close();
             }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaEnt = openFileDialog1.FileName;
                int r, g, b;
                string rutaSal = @"..\..\IMG.bmp";
                Bitmap imagen2 = new Bitmap(rutaEnt, true);

                for (int x = 0; x < imagen2.Width; x++)
                {
                    for (int y = 0; y < imagen2.Height; y++)
                    {
                        Color pixelColor = imagen2.GetPixel(x, y);
                        r = (int.Parse(textBox1.Text) + pixelColor.R) % 256;
                        g = (int.Parse(textBox2.Text) + pixelColor.G) % 256;
                        b = (int.Parse(textBox3.Text) + pixelColor.B) % 256;
                        Color newColor = Color.FromArgb(r, g, b);
                        imagen2.SetPixel(x, y, newColor);
                    }
                }
                pictureBox2.Image = imagen2;
                imagen2.Save(rutaSal, System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch(Exception)
            {

            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                int r, g, b, r1, g1, b1;
                string ruta = @"..\..\IMG.bmp";
                string rutaR = @"..\..\IMG2.bmp";
                Bitmap imagen3;
                //Sobreescribe el archivo de respaldo
                System.IO.File.Copy(ruta, rutaR, true);
                //Elimina el archivo original
                System.IO.File.Delete(ruta);
                //Toma el archivo de respaldo 
                imagen3 = new Bitmap(rutaR, true);
                
                for (int x = 0; x < imagen3.Width; x++)
                {
                    for (int y = 0; y < imagen3.Height; y++)
                    {
                        Color pixelColor = imagen3.GetPixel(x, y);
                        r = int.Parse(textBox1.Text);
                        r1 = (inv(r) + pixelColor.R) % 256;
                        g = int.Parse(textBox2.Text);
                        g1 = (inv(g) + pixelColor.G) % 256;
                        b = int.Parse(textBox3.Text);
                        b1 = (inv(b) + pixelColor.B) % 256;
                        Color newColor = Color.FromArgb(r1, g1, b1);
                        imagen3.SetPixel(x, y, newColor);
                    }
                }
                pictureBox2.Image = imagen3;
            }
            catch(Exception)
            {

            }
        }

        public int inv(int a)
        {
            a = a % 256;
            int inv = 256 - a;
            return inv;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }
    }
}
