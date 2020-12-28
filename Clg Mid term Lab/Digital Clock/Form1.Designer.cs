namespace Digital_Clock
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StopWatchLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(575, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(538, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "StopTheAlarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(846, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "StartTheAlarm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(846, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 52);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StopWatchLabel
            // 
            this.StopWatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopWatchLabel.Location = new System.Drawing.Point(48, 112);
            this.StopWatchLabel.Name = "StopWatchLabel";
            this.StopWatchLabel.Size = new System.Drawing.Size(217, 47);
            this.StopWatchLabel.TabIndex = 6;
            this.StopWatchLabel.Text = "00:00:00:000";
            this.StopWatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "StopWatch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(633, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alarm";
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Location = new System.Drawing.Point(30, 276);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(149, 27);
            this.reset.TabIndex = 9;
            this.reset.Text = "ResetTheStopWatch";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(188, 276);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(142, 27);
            this.start.TabIndex = 10;
            this.start.Text = "StartTheStopWatch";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(143, 351);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 11;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StopWatchLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StopWatchLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Timer timer2;
    }
}

