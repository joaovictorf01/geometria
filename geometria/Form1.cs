﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plana obj1 = new plana();
            obj1.ShowDialog(    );

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            espacial obj2 = new espacial();
            obj2.ShowDialog();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
