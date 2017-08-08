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
            int iInputValue = 0;
            AugustoClass myClass = new AugustoClass();

                iInputValue = Convert.ToInt16(textBox2.Text);
                    int[] list = myClass.getRandom(iInputValue);
                    int iMedian = myClass.getMedian(list);
                    MessageBox.Show("Median is:" + iMedian);
        }
    }
}
