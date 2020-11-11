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

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image;
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            /*
            image = new Bitmap("C:\\Users\\qukmo\\Desktop\\C++\\lama.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color pixel; //RGB(0, 255)
            int height = image.Height;
            int width = image.Width;

            for (int h = 0; h < height; h++)
                for (int w = 0; w < width; w++)
                {
                    pixel = image.GetPixel(w, h);
                    pixel = Color.FromArgb(pixel.R, pixel.G, pixel.R);
                    image.SetPixel(w, h, pixel);
                }
            pictureBox1.Image = image;


        }



        /*private void button4_Click(object sender, EventArgs e)
        {
            Color pixel; //RGB(0, 255)
            int height = image.Height;
            int width = image.Width;

            for (int h = 0; h < height; h++)
                for (int w = 0; w < width; w++)
                {
                    pixel = image.GetPixel(w, h);
                    pixel = Color.FromArgb(pixel.R, pixel.R, pixel.R);
                    image.SetPixel(w, h, pixel);
                }
            pictureBox1.Image = image;
        }
        */

        private void button3_Click(object sender, EventArgs e)
        {





        }
    }
}
