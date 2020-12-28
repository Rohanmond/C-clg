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

namespace SampleDatabaseApplication
{
    public partial class Form1 : Form
    {
        private string conString = SampleDatabaseApplication.Properties.Settings.Default.StudentDatabaseConnectionString;
        Student myStudent = new Student();
        public Form1()
        {
            InitializeComponent();
            StudentDetailsDataGridView.DataSource = myStudent.getStudentDetails();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Call insert method
            myStudent.StudentId = studentIDTextBox.Text;
            myStudent.StudentName = studentNameTextBox.Text;
            myStudent.StudentAge = ageNumericUpDown.Value.ToString();
            myStudent.StudentContactNo = contactDetailsTextBox.Text;
            myStudent.StudentGender = genderComboBox.SelectedItem.ToString();
            bool retV=myStudent.insertStudentsDetails(myStudent);
            if (retV)
            {
                MessageBox.Show("Insertion Successful");
                //refresh and updte the data grid
                StudentDetailsDataGridView.DataSource = myStudent.getStudentDetails();
                clearControls();
            }
            else
            {
                MessageBox.Show("Error:Insertion unsuccessful");
            }
        }

        private void clearControls()
        {
            studentIDTextBox.Text = "";
            studentNameTextBox.Text = "";
            ageNumericUpDown.Value = 18;
            contactDetailsTextBox.Text = "";
            genderComboBox.SelectedItem = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            myStudent.StudentId = studentIDTextBox.Text;
            bool retV = myStudent.deleteStudentDetails(myStudent);
            if (retV)
            {
                MessageBox.Show("Deletion Successful");
                StudentDetailsDataGridView.DataSource = myStudent.getStudentDetails();
                clearControls();
            }
            else
            {
                MessageBox.Show("Error:Deletion Unsuccessfull");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            myStudent.StudentId = studentIDTextBox.Text;
            myStudent.StudentName = studentNameTextBox.Text;
            myStudent.StudentAge = ageNumericUpDown.Value.ToString();
            myStudent.StudentContactNo = contactDetailsTextBox.Text;
            myStudent.StudentGender = genderComboBox.SelectedItem.ToString();
            bool retV=myStudent.updateStudentDetails(myStudent);
            if (retV)
            {
                MessageBox.Show("Updation is Successful");
                StudentDetailsDataGridView.DataSource = myStudent.getStudentDetails();
                clearControls();
            }
            else MessageBox.Show("Error:Updation Unsuccessfull");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            myStudent.StudentId = searchTextBox.Text;
            bool retV = myStudent.searchStudentDetails(myStudent);
            if (retV)
            {
                MessageBox.Show("Match Found");
                //StudentDetailsDataGridView.DataSource = myStudent.getStudentDetails();
                clearControls();
            }
            else MessageBox.Show("Match Not Found");
        }
    }
    class Student
    {
        private string conString = SampleDatabaseApplication.Properties.Settings.Default.StudentDatabaseConnectionString;

        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAge { get; set; }
        public string StudentContactNo { get; set; }
        public string StudentGender { get; set; }

        private const string selectQuery="Select * from StudentDetails";
        private const string insertQuery = "Insert into StudentDetails(StudentId,StudentName,StudentAge,StudentContact,StudentGender) values(@StudentId,@StudentName,@StudentAge,@StudentContact,@StudentGender)";
        private const string deleteQuery = "delete from StudentDetails where StudentId=@StudentId";
        private const string updateQuery = "Update StudentDetails set StudentName=@StudentName,StudentAge=@StudentAge,StudentContact=@StudentContact,StudentGender=@StudentGender where StudentId=@StudentId";
        private const string searchQuery = "select * from StudentDetails where StudentId=@StudentId";
        //Methods
        public DataTable getStudentDetails()
        {
            var dataTable = new DataTable();
            SqlConnection myConnection = new SqlConnection(conString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(selectQuery, myConnection);
            SqlDataAdapter myAdapter = new SqlDataAdapter(com);
            myAdapter.Fill(dataTable);
            myConnection.Close();
            return dataTable;
        }
        public bool insertStudentsDetails(Student myStudent)
        {
            int rows;
            SqlConnection myConnection = new SqlConnection(conString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(insertQuery, myConnection);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentId);
            com.Parameters.AddWithValue("@StudentName", myStudent.StudentName);
            com.Parameters.AddWithValue("@StudentAge", myStudent.StudentAge);
            com.Parameters.AddWithValue("@StudentContact", myStudent.StudentContactNo);
            com.Parameters.AddWithValue("@StudentGender", myStudent.StudentGender);
            rows = com.ExecuteNonQuery();
            myConnection.Close();
            if (rows > 0) return true;
            return false; 
        }
        public bool deleteStudentDetails(Student myStudent)
        {
            int rows;
            SqlConnection myConnection = new SqlConnection(conString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(deleteQuery, myConnection);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentId);
            rows = com.ExecuteNonQuery();
            if (rows > 0)
            {
                return true;
            }
            else return false;
        }
        public bool updateStudentDetails(Student myStudent)
        {
            int rows;
            SqlConnection myConnection = new SqlConnection(conString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(updateQuery, myConnection);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentId);
            com.Parameters.AddWithValue("@StudentName", myStudent.StudentName);
            com.Parameters.AddWithValue("@StudentAge", myStudent.StudentAge);
            com.Parameters.AddWithValue("@StudentContact", myStudent.StudentContactNo);
            com.Parameters.AddWithValue("@StudentGender", myStudent.StudentGender);
            rows = com.ExecuteNonQuery();
            myConnection.Close();
            if (rows > 0) return true;
            return false;
        }
        public bool searchStudentDetails(Student myStudent)
        {
            int rows;
            SqlConnection myConnection = new SqlConnection(conString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(searchQuery, myConnection);
            //com.Parameters.AddWithValue("@StudentName", myStudent.StudentName);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentId);
            //com.Parameters.AddWithValue("@StudentName", myStudent.StudentName);
            //com.Parameters.AddWithValue("@StudentAge", myStudent.StudentAge);
            //com.Parameters.AddWithValue("@StudentContact", myStudent.StudentContactNo);
            //com.Parameters.AddWithValue("@StudentGender", myStudent.StudentGender);
            rows = com.ExecuteNonQuery();
            myConnection.Close();
            if (rows > 0) return true;
            return false;
        }
    }
}
