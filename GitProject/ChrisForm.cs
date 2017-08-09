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
    public partial class ChrisForm : Form
    {
        public ChrisForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int[] array;
            int n = 0;

            try
            {
                n = Convert.ToInt16(textBoxNumber.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input an int");
            }
            Test oTest = new Test();    

            if(oTest.Testn(n))
            {
                ChrisClass cClass = new ChrisClass();
                array = cClass.GetRandomNumbers(n);
                stat oStat = new stat();
                MessageBox.Show("Minimum random number: " + oStat.minimumRandom(array, n));
            }
            else
            {
                MessageBox.Show("Please enter a number between 5 and 20");
            }   
        }
    }
}
