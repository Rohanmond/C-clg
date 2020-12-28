using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClgGuiApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            if (username.Equals("Rohan") && password.Equals("rohan"))
            {
                //MessageBox.Show("Hello " + username,"Important Note",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Selection mySelection= new Selection();
                this.Hide();
                mySelection.Show();
                
            }
            else MessageBox.Show("Invalid credentials");
        }
    }
}
