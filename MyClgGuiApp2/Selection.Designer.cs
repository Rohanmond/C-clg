namespace MyClgGuiApp2
{
    partial class Selection
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
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.engineeringRadioButton = new System.Windows.Forms.RadioButton();
            this.lawRadioButton = new System.Windows.Forms.RadioButton();
            this.mbaRadioButton = new System.Windows.Forms.RadioButton();
            this.streamGroupBox = new System.Windows.Forms.GroupBox();
            this.engGroupBox = new System.Windows.Forms.GroupBox();
            this.csRadioButton = new System.Windows.Forms.RadioButton();
            this.mechanicalRadioButton = new System.Windows.Forms.RadioButton();
            this.electricalRadioButton = new System.Windows.Forms.RadioButton();
            this.civilRadioButton = new System.Windows.Forms.RadioButton();
            this.petroleumRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.lawComboBox = new System.Windows.Forms.ComboBox();
            this.streamGroupBox.SuspendLayout();
            this.engGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionLabel.Location = new System.Drawing.Point(254, 19);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(281, 29);
            this.SelectionLabel.TabIndex = 0;
            this.SelectionLabel.Text = "Select Appropriate Data";
            this.SelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectionLabel.Click += new System.EventHandler(this.SelectionLabel_Click);
            // 
            // engineeringRadioButton
            // 
            this.engineeringRadioButton.AutoSize = true;
            this.engineeringRadioButton.Location = new System.Drawing.Point(6, 33);
            this.engineeringRadioButton.Name = "engineeringRadioButton";
            this.engineeringRadioButton.Size = new System.Drawing.Size(118, 24);
            this.engineeringRadioButton.TabIndex = 1;
            this.engineeringRadioButton.TabStop = true;
            this.engineeringRadioButton.Text = "Engineering";
            this.engineeringRadioButton.UseVisualStyleBackColor = true;
            this.engineeringRadioButton.CheckedChanged += new System.EventHandler(this.engineeringRadioButton_CheckedChanged);
            // 
            // lawRadioButton
            // 
            this.lawRadioButton.AutoSize = true;
            this.lawRadioButton.Location = new System.Drawing.Point(341, 33);
            this.lawRadioButton.Name = "lawRadioButton";
            this.lawRadioButton.Size = new System.Drawing.Size(61, 24);
            this.lawRadioButton.TabIndex = 2;
            this.lawRadioButton.TabStop = true;
            this.lawRadioButton.Text = "Law";
            this.lawRadioButton.UseVisualStyleBackColor = true;
            this.lawRadioButton.CheckedChanged += new System.EventHandler(this.lawRadioButton_CheckedChanged);
            // 
            // mbaRadioButton
            // 
            this.mbaRadioButton.AutoSize = true;
            this.mbaRadioButton.Location = new System.Drawing.Point(648, 33);
            this.mbaRadioButton.Name = "mbaRadioButton";
            this.mbaRadioButton.Size = new System.Drawing.Size(67, 24);
            this.mbaRadioButton.TabIndex = 3;
            this.mbaRadioButton.TabStop = true;
            this.mbaRadioButton.Text = "MBA";
            this.mbaRadioButton.UseVisualStyleBackColor = true;
            // 
            // streamGroupBox
            // 
            this.streamGroupBox.Controls.Add(this.engineeringRadioButton);
            this.streamGroupBox.Controls.Add(this.lawRadioButton);
            this.streamGroupBox.Controls.Add(this.mbaRadioButton);
            this.streamGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamGroupBox.Location = new System.Drawing.Point(12, 51);
            this.streamGroupBox.Name = "streamGroupBox";
            this.streamGroupBox.Size = new System.Drawing.Size(764, 74);
            this.streamGroupBox.TabIndex = 5;
            this.streamGroupBox.TabStop = false;
            this.streamGroupBox.Text = "Choose the stream";
            this.streamGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // engGroupBox
            // 
            this.engGroupBox.Controls.Add(this.petroleumRadioButton);
            this.engGroupBox.Controls.Add(this.civilRadioButton);
            this.engGroupBox.Controls.Add(this.electricalRadioButton);
            this.engGroupBox.Controls.Add(this.mechanicalRadioButton);
            this.engGroupBox.Controls.Add(this.csRadioButton);
            this.engGroupBox.Location = new System.Drawing.Point(18, 155);
            this.engGroupBox.Name = "engGroupBox";
            this.engGroupBox.Size = new System.Drawing.Size(758, 63);
            this.engGroupBox.TabIndex = 6;
            this.engGroupBox.TabStop = false;
            this.engGroupBox.Text = "Choose the branch in Engineering Stream";
            this.engGroupBox.Visible = false;
            // 
            // csRadioButton
            // 
            this.csRadioButton.AutoSize = true;
            this.csRadioButton.Location = new System.Drawing.Point(3, 18);
            this.csRadioButton.Name = "csRadioButton";
            this.csRadioButton.Size = new System.Drawing.Size(56, 21);
            this.csRadioButton.TabIndex = 0;
            this.csRadioButton.TabStop = true;
            this.csRadioButton.Text = "CSE";
            this.csRadioButton.UseVisualStyleBackColor = true;
            // 
            // mechanicalRadioButton
            // 
            this.mechanicalRadioButton.AutoSize = true;
            this.mechanicalRadioButton.Location = new System.Drawing.Point(128, 21);
            this.mechanicalRadioButton.Name = "mechanicalRadioButton";
            this.mechanicalRadioButton.Size = new System.Drawing.Size(100, 21);
            this.mechanicalRadioButton.TabIndex = 1;
            this.mechanicalRadioButton.TabStop = true;
            this.mechanicalRadioButton.Text = "Mechanical";
            this.mechanicalRadioButton.UseVisualStyleBackColor = true;
            // 
            // electricalRadioButton
            // 
            this.electricalRadioButton.AutoSize = true;
            this.electricalRadioButton.Location = new System.Drawing.Point(324, 21);
            this.electricalRadioButton.Name = "electricalRadioButton";
            this.electricalRadioButton.Size = new System.Drawing.Size(86, 21);
            this.electricalRadioButton.TabIndex = 2;
            this.electricalRadioButton.TabStop = true;
            this.electricalRadioButton.Text = "Electrical";
            this.electricalRadioButton.UseVisualStyleBackColor = true;
            // 
            // civilRadioButton
            // 
            this.civilRadioButton.AutoSize = true;
            this.civilRadioButton.Location = new System.Drawing.Point(492, 18);
            this.civilRadioButton.Name = "civilRadioButton";
            this.civilRadioButton.Size = new System.Drawing.Size(54, 21);
            this.civilRadioButton.TabIndex = 3;
            this.civilRadioButton.TabStop = true;
            this.civilRadioButton.Text = "Civil";
            this.civilRadioButton.UseVisualStyleBackColor = true;
            // 
            // petroleumRadioButton
            // 
            this.petroleumRadioButton.AutoSize = true;
            this.petroleumRadioButton.Location = new System.Drawing.Point(664, 21);
            this.petroleumRadioButton.Name = "petroleumRadioButton";
            this.petroleumRadioButton.Size = new System.Drawing.Size(88, 21);
            this.petroleumRadioButton.TabIndex = 4;
            this.petroleumRadioButton.TabStop = true;
            this.petroleumRadioButton.Text = "Petrolium";
            this.petroleumRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(353, 390);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // lawComboBox
            // 
            this.lawComboBox.FormattingEnabled = true;
            this.lawComboBox.Items.AddRange(new object[] {
            "BBA",
            "BCA"});
            this.lawComboBox.Location = new System.Drawing.Point(322, 224);
            this.lawComboBox.Name = "lawComboBox";
            this.lawComboBox.Size = new System.Drawing.Size(149, 24);
            this.lawComboBox.TabIndex = 7;
            this.lawComboBox.Text = "Choose one of those";
            this.lawComboBox.Visible = false;
            this.lawComboBox.SelectedIndexChanged += new System.EventHandler(this.lawComboBox_SelectedIndexChanged);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lawComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.engGroupBox);
            this.Controls.Add(this.streamGroupBox);
            this.Controls.Add(this.SelectionLabel);
            this.Name = "Selection";
            this.Text = "Selection";
            this.streamGroupBox.ResumeLayout(false);
            this.streamGroupBox.PerformLayout();
            this.engGroupBox.ResumeLayout(false);
            this.engGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.RadioButton engineeringRadioButton;
        private System.Windows.Forms.RadioButton lawRadioButton;
        private System.Windows.Forms.RadioButton mbaRadioButton;
        private System.Windows.Forms.GroupBox streamGroupBox;
        private System.Windows.Forms.GroupBox engGroupBox;
        private System.Windows.Forms.RadioButton petroleumRadioButton;
        private System.Windows.Forms.RadioButton civilRadioButton;
        private System.Windows.Forms.RadioButton electricalRadioButton;
        private System.Windows.Forms.RadioButton mechanicalRadioButton;
        private System.Windows.Forms.RadioButton csRadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox lawComboBox;
    }
}