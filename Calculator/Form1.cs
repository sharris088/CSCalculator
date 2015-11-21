using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double total1 = 0;
        double total2 = 0;
        private bool btnPlusClicked = false;
        private bool btnMinusClicked = false;
        private bool btnDivideClicked = false;
        private bool btnMultiplyClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                btnPlusClicked = true;
                txtDisplay2.Text = total1.ToString() + " +";
            }
            catch
            {
                MessageBox.Show("Numerical values only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDisplay.Clear();
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                total1 = double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                btnMinusClicked = true;
                txtDisplay2.Text = total1.ToString() + " -";
            }
            catch
            {
                MessageBox.Show("Numerical values only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDisplay.Clear();
            }

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                total1 = double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                btnDivideClicked = true;
                txtDisplay2.Text = total1.ToString() + " /";
            }
            catch
            {
                MessageBox.Show("Numerical values only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDisplay.Clear();
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                total1 = double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                btnMultiplyClicked = true;
                txtDisplay2.Text = total1.ToString() + " *";
            }
            catch
            {
                MessageBox.Show("Numerical values only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDisplay.Clear();
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (btnPlusClicked)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Text = total2.ToString();
                total1 = 0;
                txtDisplay2.Clear();
                btnPlusClicked = false;
            }
            if (btnMinusClicked)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
                txtDisplay.Text = total2.ToString();
                total1 = 0;
                txtDisplay2.Clear();
                btnMinusClicked = false;
            }
            if (btnDivideClicked)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
                txtDisplay.Text = total2.ToString();
                if (txtDisplay.Text == "Infinity")
                {
                    txtDisplay.Clear();
                    MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                total1 = 0;
                txtDisplay2.Clear();
                btnDivideClicked = false;
            }
            if (btnMultiplyClicked)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
                txtDisplay.Text = total2.ToString();
                total1 = 0;
                txtDisplay2.Clear();
                btnMultiplyClicked = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void bntPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.IndexOf('-') != 0)
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Replace("-", "");
            }
            
        }

    }
}
