using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumGameToluA
{
    public partial class frmRandomNumberGuessingGame : Form
    {
        public frmRandomNumberGuessingGame()
        {
            InitializeComponent();
        }

        private void RandomNumberGuessingGameForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            const int MY_NUMBER = 7;
            int UserNumber;

            UserNumber = int.Parse(txtNumber.Text);

            if (UserNumber == MY_NUMBER)
            {
                btnTryAgain.Show();
                lblAnswer.Hide();
            }
            else
            {
                lblAnswer.Show();
            }
        }
    }
}
