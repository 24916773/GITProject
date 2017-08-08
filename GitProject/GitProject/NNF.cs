using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GitProject
{
    public partial class NNF : Form
    {
        GenNum GTEngine = new GenNum();
        stat statistical = new stat();
        Test tn = new Test();
        int[] RandomNR;

        public NNF()
        {
            InitializeComponent();
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtBoxAns.Text);
                richTextBox1.AppendText("\n");
                RandomNR = new int[n];
                for (int i = 0; i <= n - 1; i++)
                {
                    RandomNR[i] = GTEngine.Generate();
                    richTextBox1.AppendText(RandomNR[i] + ", ");
                }
                richTextBox1.AppendText("\n");
                if (tn.Testn(n) == true)
                {
                    MessageBox.Show(Convert.ToString("Success: The Mean of the random numbers generated is :" + statistical.calcMean(RandomNR)));
                }
                else
                {
                    MessageBox.Show("Error: Number not between 5 or 20");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Please enter a valid number" + ex);
            }
           
        }

        
        
    }    
}
