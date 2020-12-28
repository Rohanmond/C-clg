using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWatch;
        System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed;
            stopWatch = new Stopwatch();
        }
        private void timer_Elapsed(object sender,System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if(currentTime.Hour==userTime.Hour && userTime.Minute==currentTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLable upd = UpdateDataLabel;
                    if (label2.InvokeRequired)
                    {
                        Invoke(upd, label2, "Stop");
                    }
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"F:\Clg class codes\Clg Mid term Lab\Digital Clock\clock4.wav";
                    player.PlayLooping();
                    
                    MessageBox.Show("Ring !!RIng!!!!!!");
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        delegate void UpdateLable(Label lbl, string value);
            void UpdateDataLabel(Label lbl,string value)
            {
            label2.Text = value;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label2.Text = "Stop.......";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Start();
            label2.Text = "Running....";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void start_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            this.StopWatchLabel.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}
