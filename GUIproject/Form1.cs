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
            cal.FormBorderStyle = FormBorderStyle.None;
            Panelview.Controls.Add(cal);
            cal.Show();
        }
    }
}
