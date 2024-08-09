using MySql.Data.MySqlClient;
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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add the Error Exception for the code
            try
            {
                string name = textBox1.Text;
                string id = textBox2.Text;
                string address = textBox3.Text;
                string contact = textBox4.Text;
                string department = comboBox1.Text;
                DBconnection db = new DBconnection();
                MySqlConnection con = db.getcon();

                string query = "INSERT INTO employee (name,id,address,contact,department) VALUES (@name, @id,@address,@contact,@department)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter the vaild numeric value ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employee_Load(object sender, EventArgs e)
        {

        }
    }
}
