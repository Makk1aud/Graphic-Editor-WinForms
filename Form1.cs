using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{

    public partial class Form1 : Form
    {
        private Point previosPoint, point;
        private Bitmap bitmapImage;
        private Pen blackPen;
        private Graphics graphics;

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = 
                "Image files (*.BMP, *.JPG, " + "*.GIF, *.PNG)|*.bmp;*.jpg;*.gif;*.png";
            if(DialogResult.OK == openFileDialog.ShowDialog())
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                int width = image.Width;
                int height = image.Height;
                //mainPctBox.Width = width;
                //mainPctBox.Height = height;
                bitmapImage = new Bitmap(image, mainPctBox.Width, mainPctBox.Height);
                mainPctBox.Image = bitmapImage;
                graphics= Graphics.FromImage(mainPctBox.Image);
                EnableButtons(true);
            }
            
        }

        private void EnableButtons(bool enable)
        {
            saveBtn.Enabled = enable;
            blackWhiteBtn.Enabled = enable;
            mainPctBox.Enabled = enable;
            buttonClear.Enabled = enable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableButtons(false);
            blackPen = new Pen(Color.Black, 1);

        }

        private void mainPctBox_MouseDown(object sender, MouseEventArgs e)
        {
            previosPoint.X = (int)e.X;
            previosPoint.Y = (int)e.Y;
        }

        private void mainPctBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                point.X = (int)e.X;
                point.Y = (int)e.Y;
                graphics.DrawLine(blackPen, previosPoint, point);

                previosPoint = point;

                mainPctBox.Invalidate();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Сохранить картинку как ";
            saveFileDialog.OverwritePrompt= false;
            saveFileDialog.CheckFileExists=false;
            saveFileDialog.Filter = 
                "Bitmap File(*.bmp)|*.bmp|" + 
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" + 
                "PNG File(*.png)|*.png";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                string filExtn = fileName.Remove(0, fileName.Length - 3);

                switch (filExtn)
                {
                    case "bmp":
                        bitmapImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp); break;
                    case "jpg":
                        bitmapImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bitmapImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif); break;
                    case "tif":
                        bitmapImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bitmapImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Png); break;
                    default:
                        break;
                }
            }
        }

        private void blackWhite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitmapImage.Width; i++)
            {
                for (int j = 0; j < bitmapImage.Height; j++)
                {
                    int R = bitmapImage.GetPixel(i, j).R;
                    int G = bitmapImage.GetPixel(i, j).G;
                    int B = bitmapImage.GetPixel(i, j).B;
                    int Gray = (R + G + B) / 7;

                    Color p = Color.FromArgb(255, Gray, Gray, Gray);

                    bitmapImage.SetPixel(i, j, p);
                }
            }
            Refresh();
            blackWhiteBtn.Enabled= false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void penSizeTrBar_Scroll(object sender, EventArgs e)
        {
            blackPen.Width = penSizeTrBar.Value;
            penSixeTxb.Text = penSizeTrBar.Value.ToString();
        }

        public Form1()
        {
            InitializeComponent();           
        }

        private void penSixeTxb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                blackPen.Width = Convert.ToInt32(penSixeTxb.Text);
            }
            catch(Exception ex) { }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            mainPctBox.Image= null;

            EnableButtons(false);
        }

        public void ChangepPenColor(object sender, EventArgs e)
        {
            Button button = sender as Button;
            blackPen.Color = button.BackColor;
        }
    }
}
