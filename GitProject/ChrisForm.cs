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
            try
            {
                int n = Convert.ToInt16(textBoxNumber.Text);
                if(n>=5 && n <=20)
                {
                    ChrisClass cClass = new ChrisClass(n);
                    MessageBox.Show("Minimum random number: " + cClass.minimumRandom());
                }
                else
                {
                    Exception ex = new Exception("Please enter a number between 5 and 20");
                    throw ex;
                }   
            }
            catch(Exception)
            {
                MessageBox.Show("Please enter a number between 5 and 20");
            }
        }
    }
}
