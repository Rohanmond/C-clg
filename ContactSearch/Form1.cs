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

namespace ContactSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sReader = new StreamReader("F:\\Clg class codes\\Clg Mid term Lab\\Context searching App\\Dta.txt");
            string searchText = textBox1.Text.ToLower();
            string text;
            if(searchText==null || searchText == "")
            {
                MessageBox.Show("Pls enter text");
            }
            else
            {
                string temp = sReader.ReadLine();
                while (temp != null) {
                    if (searchText.Contains(temp.ToLower()))
                    {
                        temp = sReader.ReadLine();
                        textBox2.Text =temp;
                    }
                    temp = sReader.ReadLine();
                }
            }
        }
    }
}
