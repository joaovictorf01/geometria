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
    public partial class plana : Form
    {
        public plana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Quadrado qua = new Quadrado();

            qua.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            triângulo tri = new triângulo();
            tri.ShowDialog();


        
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            círculo cir = new círculo();
            cir.ShowDialog();

           
        }
    }
}
