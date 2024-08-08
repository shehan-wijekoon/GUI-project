using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIproject
{
    public partial class calculate : Form
    {
        public calculate()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hours = Convert.ToInt32(Txthours.Text);
            int ot = Convert.ToInt32(TxtOt.Text);
            double bonus = Convert.ToDouble(Txtbonus.Text);

            double finalsal = 0;

            if(Cmbdepartment.SelectedIndex == 0)
            {
                finalsal = hours*2000 + ot*1000 + bonus;    
            }
            else if(Cmbdepartment.SelectedIndex == 1)
            {
                finalsal = hours * 1000 + ot * 1000 + bonus;
            }
            else if(Cmbdepartment.SelectedIndex == 2)
            {
               finalsal = hours * 1000 + ot * 500 + bonus;
            }
            else
            {
               finalsal = hours * 2000 + ot * 1000 + bonus;
            }


            Txtfinal.Text = finalsal.ToString();
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
