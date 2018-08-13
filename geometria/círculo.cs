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
    public partial class círculo : Form
    {
        public círculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio = Convert.ToDouble(tbr.Text);
               
                    double resultado = 3.14 * Math.Pow(raio, 2);

            tbResult.Text = Convert.ToString(resultado);


        }
    }
}
