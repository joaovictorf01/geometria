using System;
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
    public partial class Quadrado : Form
    {
        public Quadrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double l1 = Convert.ToDouble(tbL1.Text);

            double l2 = Convert.ToDouble(tbL2.Text);

            double result = l1 * l2;
            tbResult.Text = Convert.ToString(result);
            
            

        }
    }
}
