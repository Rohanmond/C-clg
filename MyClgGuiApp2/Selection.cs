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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SelectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void engineeringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (engineeringRadioButton.Checked)
            {
                engGroupBox.Visible = true;
            }
            else
            {
                engGroupBox.Visible = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            GetSelection();
        }

        private void GetSelection()
        {
            if (engineeringRadioButton.Checked)
            {
                if (csRadioButton.Checked) MessageBox.Show("U hve choosen CS under Engineering", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (mechanicalRadioButton.Checked) MessageBox.Show("U hve choosen Mechanical under Engineering", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (civilRadioButton.Checked) MessageBox.Show("U hve choosen Civil under Engineering", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (electricalRadioButton.Checked) MessageBox.Show("U hve choosen Electrical under Engineering", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (petroleumRadioButton.Checked) MessageBox.Show("U hve choosen Petroleum under Engineering", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("U hve not selected anything","" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (lawRadioButton.Checked)
            {
                if (lawComboBox.SelectedIndex == 0) MessageBox.Show("U hve choosen BBA under Law", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if(lawComboBox.SelectedIndex==1) MessageBox.Show("U hve choosen BCA under Law", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("U hve not selected anything", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lawComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lawRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lawRadioButton.Checked)
            {
                lawComboBox.Visible = true;
            }
            else
            {
                lawComboBox.Visible = false;
            }
        }
    }
}
