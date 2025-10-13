using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Visor_de_imagenes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
            cmbImagen.SelectedIndex = 0;
            Garfield.ImageLocation = "E:\\Users\\Pavilion\\Downloads\\guia8\\Visor\\Visor de imagenes\\Visor de imagenes\\Imagenes\\" + cmbImagen.SelectedItem;
            textBox1.Text = "E:\\Users\\Pavilion\\Downloads\\guia8\\Visor\\Visor de imagenes\\Visor de imagenes\\Imagenes\\" + cmbImagen.SelectedItem;
            toolStripButton3.Checked = true;
        }

        private void pictureBox1_RightClick(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                toolStripButton2.Checked = false;
                toolStripButton1.Checked = true;
                checkBox2.Checked = false;
                Garfield.ImageLocation = "E:\\Users\\Pavilion\\Downloads\\guia8\\Visor\\Visor de imagenes\\Visor de imagenes\\Imagenes\\" + cmbImagen.SelectedItem;
                checkBox1.AutoCheck = false;

            }
            else
            {
                checkBox1.AutoCheck = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Garfield.ImageLocation = "E:\\Users\\Pavilion\\Downloads\\guia8\\Visor\\Visor de imagenes\\Visor de imagenes\\Imagenes\\" + cmbImagen.SelectedItem;
            textBox1.Text = Garfield.ImageLocation;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                Garfield.SizeMode = PictureBoxSizeMode.CenterImage;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox3.AutoCheck = false;
                toolStripButton3.Checked= true;
                toolStripButton4.Checked = false;
                toolStripButton5.Checked = false;
            }
            else
            {
                checkBox3.AutoCheck = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Garfield.SizeMode = PictureBoxSizeMode.StretchImage;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
                checkBox4.AutoCheck = false;
                toolStripButton3.Checked = false;
                toolStripButton4.Checked = true;
                toolStripButton5.Checked = false;
            }
            else
            {
                checkBox4.AutoCheck = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                Garfield.SizeMode = PictureBoxSizeMode.Zoom;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.AutoCheck = false;
                toolStripButton3.Checked = false;
                toolStripButton4.Checked = false;
                toolStripButton5.Checked = true;
            }
            else
            {
                checkBox5.AutoCheck = true;
            }
        }

        private void centradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3.Checked = true;
            toolStripButton4.Checked = false;
            toolStripButton5.Checked = false;
            checkBox3.Checked = true;
            Garfield.SizeMode = PictureBoxSizeMode.CenterImage;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void ajustadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3.Checked = false;
            toolStripButton4.Checked = true;
            toolStripButton5.Checked = false;
            checkBox4.Checked = true;
            Garfield.SizeMode = PictureBoxSizeMode.StretchImage;
            checkBox3.Checked = false;
            checkBox5.Checked = false;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3.Checked = false;
            toolStripButton4.Checked = false;
            toolStripButton5.Checked = true;
            checkBox5.Checked = true;
            Garfield.SizeMode = PictureBoxSizeMode.Zoom;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            toolStripButton3.Checked = true;
            toolStripButton4.Checked = false;
            toolStripButton5.Checked = false;
            checkBox3.Checked = true;
            Garfield.SizeMode = PictureBoxSizeMode.CenterImage;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            toolStripButton3.Checked = false;
            toolStripButton4.Checked = true;
            toolStripButton5.Checked = false;
            checkBox4.Checked = true;
            Garfield.SizeMode = PictureBoxSizeMode.StretchImage;
            checkBox3.Checked = false;
            checkBox5.Checked = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            toolStripButton3.Checked = false;
            toolStripButton4.Checked = false;
            toolStripButton5.Checked = true;
            checkBox5.Checked = true;
            Garfield.SizeMode = PictureBoxSizeMode.Zoom;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbImagen.SelectedIndex < cmbImagen.Items.Count-1)
            {
                cmbImagen.SelectedIndex = cmbImagen.SelectedIndex + 1;
            }
            else
            {
                cmbImagen.SelectedIndex = 0;
            }
            Garfield.ImageLocation = "E:\\Users\\Pavilion\\Downloads\\guia8\\Visor\\Visor de imagenes\\Visor de imagenes\\Imagenes\\" + cmbImagen.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (cmbImagen.SelectedIndex > 0)
                {
                    cmbImagen.SelectedIndex = cmbImagen.SelectedIndex - 1;
                }
                else
                {
                    cmbImagen.SelectedIndex = cmbImagen.Items.Count-1;
                }
                Garfield.ImageLocation = "E:\\Users\\Pavilion\\Downloads\\guia8\\Visor\\Visor de imagenes\\Visor de imagenes\\Imagenes\\" + cmbImagen.SelectedItem;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbImagen.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbImagen.SelectedIndex = cmbImagen.Items.Count-1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            toolStripButton1.Checked = true;
            toolStripButton2.Checked = false;
            checkBox2.Checked = false;
            Garfield.ImageLocation = "E:\\Users\\Pavilion\\Downloads\\guia8\\Visor\\Visor de imagenes\\Visor de imagenes\\Imagenes\\" + cmbImagen.SelectedItem;

        }

        private void Izq_Opening(object sender, CancelEventArgs e)
        {

        }

        private void girar90ALaIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Garfield.Image != null)
            {
                Garfield.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Garfield.Refresh();
            }
        }

        private void girar90ALaDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Garfield.Image != null)
            {
                Garfield.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Garfield.Refresh();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Garfield.Image != null)
            {
                try
                {
                    Clipboard.SetImage(Garfield.Image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al copiar imagen." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Bitmap Gris(Bitmap original)
        {
            if (original == null) return null;
            Bitmap bmp = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Width; y++)
            {
                for (int x = 0; x < original.Height; x++)
                {
                    Color pixelColor = original.GetPixel(y, x);
                    int gris = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    Color newColor = Color.FromArgb(pixelColor.A, gris, gris, gris);
                    bmp.SetPixel(y, x, newColor);
                }
            }

            return bmp;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                toolStripButton1.Checked = false;
                toolStripButton2.Checked = true;
                checkBox1.Checked = false;
                Garfield.Image = Gris(new Bitmap(Garfield.Image));
                checkBox2.AutoCheck = false;
            }
            else
            {
                checkBox2.AutoCheck = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = true;
            checkBox1.Checked = false;
            Garfield.Image = Gris(new Bitmap(Garfield.Image));

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            toolStripButton1.Checked = true;
            toolStripButton2.Checked = false;
            checkBox2.Checked = false;
            Garfield.ImageLocation = "E:\\Users\\Pavilion\\Downloads\\guia8\\Visor\\Visor de imagenes\\Visor de imagenes\\Imagenes\\" + cmbImagen.SelectedItem;

        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = true;
            checkBox1.Checked = false;
            Garfield.Image = Gris(new Bitmap(Garfield.Image));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Garfield.Image == null)
            {
                MessageBox.Show("No image to save.");
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Guardar Imagen";
                saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveDialog.DefaultExt = "png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    ImageFormat format = ImageFormat.Png;
                    string ext = Path.GetExtension(saveDialog.FileName).ToLower();

                    if (ext == ".jpg") format = ImageFormat.Jpeg;
                    else if (ext == ".bmp") format = ImageFormat.Bmp;

                    Garfield.Image.Save(saveDialog.FileName, format);
                    MessageBox.Show("Imagen Guardada con exito!");
                }


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("E:\\Users\\Pavilion\\Downloads\\guia8\\Visor\\Visor de imagenes\\Visor de imagenes\\Imagenes\\");
            FileInfo[] imageFiles = dir.GetFiles("*.*")
                .Where(f => f.Extension.ToLower() == ".jpg" ||
                            f.Extension.ToLower() == ".png" ||
                            f.Extension.ToLower() == ".bmp" ||
                            f.Extension.ToLower() == ".gif")
                .ToArray();

            cmbImagen.Items.Clear();

            foreach (FileInfo file in imageFiles)
            {
                cmbImagen.Items.Add(file.Name); 
            }

            if (cmbImagen.Items.Count > 0)
                cmbImagen.SelectedIndex = 0;


        }
    }
}
