
namespace DBDemo2
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
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.semesterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(776, 99);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnBranch,
            this.ColumnSemester});
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 247);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 125;
            // 
            // ColumnBranch
            // 
            this.ColumnBranch.HeaderText = "Branch";
            this.ColumnBranch.MinimumWidth = 6;
            this.ColumnBranch.Name = "ColumnBranch";
            this.ColumnBranch.Width = 125;
            // 
            // ColumnSemester
            // 
            this.ColumnSemester.HeaderText = "Semester";
            this.ColumnSemester.MinimumWidth = 6;
            this.ColumnSemester.Name = "ColumnSemester";
            this.ColumnSemester.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(746, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 22);
            this.textBox1.TabIndex = 3;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(776, 355);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 4;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(776, 212);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // branchTextBox
            // 
            this.branchTextBox.Location = new System.Drawing.Point(776, 253);
            this.branchTextBox.Name = "branchTextBox";
            this.branchTextBox.Size = new System.Drawing.Size(100, 22);
            this.branchTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(696, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Branch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Semester";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(776, 168);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.IdNumericUpDown.TabIndex = 13;
            // 
            // semesterNumericUpDown
            // 
            this.semesterNumericUpDown.Location = new System.Drawing.Point(776, 299);
            this.semesterNumericUpDown.Name = "semesterNumericUpDown";
            this.semesterNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.semesterNumericUpDown.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.semesterNumericUpDown);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.branchTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSemester;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox branchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.NumericUpDown semesterNumericUpDown;
    }
}

