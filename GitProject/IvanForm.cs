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
    public partial class IvanForm : Form
    {
        IvanClass stat = new IvanClass();
        Test betweentest = new Test();
        int[] numArray;
        int largest;
        public IvanForm()
        {
            InitializeComponent();
        }

        private void IvanForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Name: ";
            label2.Text = "Ivan de Wit";
            richTextBox1.AppendText("\r\n");
            richTextBox1.AppendText("The numbers are: \r\n");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            numArray = new int[n];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = stat.Randomizer();
                richTextBox1.AppendText(numArray[i].ToString()+ "\r\n");
                largest = stat.largest(numArray);
            }

            if (betweentest.Testn(n) == true)
            {
                MessageBox.Show("The Largest Number of the " + n + " numbers is " + largest);
            }
            else
            {
                MessageBox.Show("Please enter a number between 5 and 20");
            }
        }
    }
}
