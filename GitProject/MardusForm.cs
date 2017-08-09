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
    public partial class MardusForm : Form
    {
        public MardusForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test testNum = new Test();
            bool mardus;
            mardus = testNum.Testn(Convert.ToInt16(ranAmount.Text));
            int gCD;
            MardusClass myClass = new MardusClass();
            if (mardus == true)
            {
                int[] list = myClass.getRandom(Convert.ToInt16(ranAmount.Text));
                Answers.Clear();
                int checkSpace;
                for (int i = 0; i < list.Length; i++)
                {
                    Answers.AppendText(Convert.ToString(list[i]+" "));
                    checkSpace = i % 5;
                    if (checkSpace == 0)
                    {
                        Answers.AppendText("\n");
                    }
                }



                stat tstNums = new stat();

                gCD = tstNums.GCD(list);
                MessageBox.Show(Convert.ToString(gCD));
            }
            else
            {
                MessageBox.Show("Please make sure that the number that was entered is betwwen 5 and 20");
            }
        }

        private void MardusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
