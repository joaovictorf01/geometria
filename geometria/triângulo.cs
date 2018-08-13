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
    public partial class triângulo : Form
    {
        public triângulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double l1 = Convert.ToDouble(tbL1.Text);

            double l2 = Convert.ToDouble(tbl2.Text);
              double result = l1 * l2 / 2;

            tbResult.Text = Convert.ToString(result);

            
              
                ;
            

        }
    }
}
