using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathQuiz
{
    public partial class MathQuizTemplate : Form
    {
        Random randomize = new Random();
        int addEnd1, addEnd2,timeLeft;
        int subEnd1, subEnd2;
        int proEnd1, proEnd2;
        int divEnd1, divEnd2;
        public MathQuizTemplate()
        {
            InitializeComponent();
        }

        private void DummyLabel_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startTheQuiz();
            startButton.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the correct answer!!!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft -= 1;
                timeLabel.Text = timeLeft.ToString();
                if (timeLeft <= 8) timeLabel.BackColor = Color.Red;
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time is up!!!";
                MessageBox.Show("Quiz is finished");
                sum.Value = addEnd1 + addEnd2;
                difference.Value = subEnd1 - subEnd2;
                product.Value = proEnd1 * proEnd2;
                quotient.Value = divEnd1 / divEnd2;
                startButton.Enabled = true;
                timeLabel.BackColor = Color.White;
            }
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void sum_Enter(object sender, EventArgs e)
        {
            NumericUpDown answer = sender as NumericUpDown;
            if (answer != null)
            {
                answer.Select(0, answer.Value.ToString().Length);
            }
        }

        public void startTheQuiz()
        {
            //for addition
            addEnd1 = randomize.Next(20,51);
            addEnd2 = randomize.Next(30,51);
            plusLeftLabel.Text = addEnd1.ToString();
            plusRightLabel.Text = addEnd2.ToString();
            sum.Value = 0;

            //for subtraction
            subEnd1 = randomize.Next(51,100);
            subEnd2 = randomize.Next(1,51);
            minusLeftLabel.Text = subEnd1.ToString();
            minusRightLabel.Text = subEnd2.ToString();
            difference.Value = 0;

            //for multiplication
            proEnd1 = randomize.Next(1,11);
            proEnd2 = randomize.Next(1,11);
            mulLeftLabel.Text = proEnd1.ToString();
            mulRightLabel.Text = proEnd2.ToString();
            product.Value = 0;

            //for division
            divEnd1 = randomize.Next(51,100);
            divEnd2 = randomize.Next(1,51);
            while (true)
            {
                if (divEnd1 % divEnd2 == 0) break;
                else
                {
                    divEnd1 = randomize.Next(51, 100);
                    divEnd2 = randomize.Next(20);
                }
            }
            divLeftLabel.Text = divEnd1.ToString();
            divRightLabel.Text = divEnd2.ToString();
            quotient.Value = 0;

            timeLeft = 20;
            timeLabel.Text = timeLeft.ToString() + " Seconds!";
            timer1.Start();
        }
        private bool checkTheAnswer()
        {
            if (addEnd1 + addEnd2 == sum.Value && subEnd1-subEnd2==difference.Value && proEnd1*proEnd2==product.Value && divEnd1/divEnd2==quotient.Value)
            {
                return true;
            }
            else return false;
        }
    }
}
