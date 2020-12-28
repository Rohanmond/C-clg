using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace DBDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(DBDemo2.Properties.Settings.Default.StudentDataConnectionString);
            myConnection.Open();
            string id = textBox1.Text;
            int ID = Int32.Parse(id);
            SqlCommand myCommand = new SqlCommand("Select * from Student where Id="+id, myConnection);
            SqlDataReader myReader=  myCommand.ExecuteReader();
            while (myReader.Read())
            {
                /*listBox1.Items.Add(myReader.GetInt32(0));
                listBox1.Items.Add(myReader.GetString(1));
                listBox1.Items.Add(myReader.GetString(2));
                listBox1.Items.Add(myReader.GetInt32(3));*/
                dataGridView1.Rows.Add(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetInt32(3));
            }
            myConnection.Close();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(DBDemo2.Properties.Settings.Default.StudentDataConnectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand((string.Format("Insert Into Student values({0},{1},{2},{3})", IdNumericUpDown.Value, nameTextBox.Text, branchTextBox.Text, semesterNumericUpDown.Value)), myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                /*listBox1.Items.Add(myReader.GetInt32(0));
                listBox1.Items.Add(myReader.GetString(1));
                listBox1.Items.Add(myReader.GetString(2));
                listBox1.Items.Add(myReader.GetInt32(3));*/
                dataGridView1.Rows.Add(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetInt32(3));
            }
        }

    }
}
