using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitProject
{
    public partial class FormChris : Form
    {
        public FormChris()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            statChris statObj = new statChris(Convert.ToInt16(textBoxNumber.Text));
            MessageBox.Show("Minimun of the random numbers: " + statObj.minNumber());
        }
    }
}
