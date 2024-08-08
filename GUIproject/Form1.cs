using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace GUIproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {
            calculate cal = new calculate() { TopLevel = false, TopMost = true };
            Panelview.Controls.Add(cal);
            cal.BringToFront();
            cal.Show();
        }

        private void Btnemp_Click(object sender, EventArgs e)
        {
            employee emp = new employee() { TopLevel = false, TopMost = true };
            Panelview.Controls.Add(emp);
            emp.BringToFront();
            emp.Show();
        }

        private void Panelview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            details det = new details() { TopLevel = false, TopMost = true };
            Panelview.Controls.Add(det);
            det.BringToFront();
            det.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
