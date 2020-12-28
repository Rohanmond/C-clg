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
namespace File_IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            StreamReader reader = null;
            openFileDialog1.ShowDialog();
            string s = openFileDialog1.FileName;
            try
            {
                reader = new StreamReader(s);
                textBox1.Text = reader.ReadToEnd();
            }
            catch(FileNotFoundException f)
            {
                MessageBox.Show("File Not Found", "Error");
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message, "Error");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = null;
            openFileDialog1.ShowDialog();
            string s=openFileDialog1.FileName;
            try
            {
                writer = new StreamWriter(s);
                writer.Write(textBox1.Text);
            }
            catch(DirectoryNotFoundException e1)
            {
                MessageBox.Show(e1.Message, "Error");
            }
            catch(Exception e123)
            {
                MessageBox.Show(e123.Message, "Error");
            }
            finally
            {
                if (writer != null)
                {
                    MessageBox.Show("Saving Complete");
                    writer.Close();
                }
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
            string text = this.textBox2.Text;
            string text2 = this.textBox1.Text;
            char[] spearator = { ',', ' ' };

            // using the method 
            String[] strlist = text2.Split(spearator);
            foreach (String s in strlist)
            {
                if (s.Contains(text))
                    outputWindow.Text=s;
            }
           

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Input_Click(object sender, EventArgs e)
        {
            
        }
    }
}
