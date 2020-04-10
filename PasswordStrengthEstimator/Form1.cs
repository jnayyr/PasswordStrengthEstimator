using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordStrengthEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEstimateStrength_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (password.Length >= 10 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                lblResult.Text = "Good";
                lblResult.BackColor = Color.LightGreen;
            }
            else
            {
                lblResult.Text = "Weak";
                lblResult.BackColor = Color.Red;
            }
        }
    }
}
