
namespace SampleDatabaseApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.contactDetailsTextBox = new System.Windows.Forms.TextBox();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.StudentDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.InsertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(210, 96);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.studentIDTextBox.TabIndex = 6;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(210, 145);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.studentNameTextBox.TabIndex = 7;
            // 
            // contactDetailsTextBox
            // 
            this.contactDetailsTextBox.Location = new System.Drawing.Point(210, 249);
            this.contactDetailsTextBox.Name = "contactDetailsTextBox";
            this.contactDetailsTextBox.Size = new System.Drawing.Size(100, 22);
            this.contactDetailsTextBox.TabIndex = 8;
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(210, 199);
            this.ageNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.ageNumericUpDown.TabIndex = 9;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genderComboBox.Location = new System.Drawing.Point(209, 294);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 24);
            this.genderComboBox.TabIndex = 10;
            // 
            // StudentDetailsDataGridView
            // 
            this.StudentDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDetailsDataGridView.Location = new System.Drawing.Point(496, 96);
            this.StudentDetailsDataGridView.Name = "StudentDetailsDataGridView";
            this.StudentDetailsDataGridView.RowHeadersWidth = 51;
            this.StudentDetailsDataGridView.RowTemplate.Height = 24;
            this.StudentDetailsDataGridView.Size = new System.Drawing.Size(619, 248);
            this.StudentDetailsDataGridView.TabIndex = 11;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(54, 484);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 12;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(209, 484);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(371, 484);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(525, 484);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(855, 484);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(855, 443);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 22);
            this.searchTextBox.TabIndex = 17;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 605);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.StudentDetailsDataGridView);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.contactDetailsTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox contactDetailsTextBox;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DataGridView StudentDetailsDataGridView;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}

