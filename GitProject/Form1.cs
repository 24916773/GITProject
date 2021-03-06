﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LouisForm lform = new LouisForm();
            lform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AugustoForm form = new AugustoForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IvanForm frm = new IvanForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MardusForm nwForm = new MardusForm();
            nwForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NNF Neandrefrm = new NNF();
            Neandrefrm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChrisForm cForm = new ChrisForm();
            cForm.Show();
        }
    }
}
