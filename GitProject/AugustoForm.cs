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
    public partial class AugustoForm : Form
    {
        public AugustoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iInputValue = 0;// inputted value
            AugustoClass oClass = new AugustoClass();// class containing random method generater
            Test oTest = new Test();// test class containing test for between 5 and 20
            stat oStat = new stat();// stat class containing stat method
            iInputValue = Convert.ToInt16(textBox2.Text);

            if (oTest.Testn(iInputValue))
            {
                int[] list = oClass.GetRandomArray(iInputValue);
                int iMedian = oStat.GetMedian(list);
                MessageBox.Show("Median is:" + iMedian);
            }
            else
            {
                MessageBox.Show("Input a value between 5 and 20");
            }
        }
    }
}
