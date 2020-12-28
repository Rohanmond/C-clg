using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {
        List<string> dirPaths = new List<string>();
        public int n=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //to clear the picture and the image property set to null

            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //to open the dialog box
            /*if (true)
            {
                openFileDialog1.ShowDialog();
            }*/
            //show the open file dialog box and if user selects any picture file and 
            //click on Ok then it will be visible on the picture box
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                dirPaths.Add(openFileDialog1.FileName);
                n = dirPaths.Count-1;
            }
        }

        private void stretchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stretchCheckBox.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (n < dirPaths.Count-1)
            {
                n += 1;
                pictureBox1.Load(dirPaths[n]);
                
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
            
        {
            if (n > 0)
            {
                n -= 1;
                pictureBox1.Load(dirPaths[n]);
                
            }
            
        }
    }
}
