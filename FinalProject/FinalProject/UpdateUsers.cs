using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UpdateUsers : Form
    {
        public UpdateUsers()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Students SET username='" + textBox1.Text + "', password='" + textBox3.Text + "'" + " WHERE username='" +textBox4.Text + "' and password='" + textBox2.Text + "'";
            MessageBox.Show(query);
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            int i = sqlcommand.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Nashod!");
            }
            sqlconnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
