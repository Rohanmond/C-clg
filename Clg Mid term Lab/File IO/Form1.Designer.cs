namespace File_IO
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Button();
            this.outputWindow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 234);
            this.textBox1.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.AutoSize = true;
            this.openButton.Location = new System.Drawing.Point(69, 316);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 27);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(150, 316);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 27);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(548, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(548, 91);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(75, 23);
            this.Input.TabIndex = 4;
            this.Input.Text = "Search";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // outputWindow
            // 
            this.outputWindow.Location = new System.Drawing.Point(558, 132);
            this.outputWindow.Multiline = true;
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.Size = new System.Drawing.Size(188, 193);
            this.outputWindow.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.TextBox outputWindow;
    }
}

