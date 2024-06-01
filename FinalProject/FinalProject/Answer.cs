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
    public partial class Answer : Form
    {
        public Answer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ID22 = textBox1.Text;
                string query = "SELECT * FROM requests WHERE person='" + ID22 + "'";
                SqlConnection sqlconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand command = new SqlCommand(query, sqlconnection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Close();
                    //sqlconnection.Close();
                    textBox1.Hide();
                    label1.Hide();
                    button1.Hide();
                    textBox2.Show();
                    label2.Show();
                    textBox3.Show();
                    label3.Show();
                    string query2 = "SELECT subject FROM requests WHERE person='" + ID22 + "'";
                    SqlCommand command2 = new SqlCommand(query2, sqlconnection);
                    textBox3.Text = "بررسی شد";
                    var reader =command.ExecuteReader();
                    if (reader.HasRows)
                        textBox2.Text ="سایر";
                    else
                        MessageBox.Show("You don't have any answer!");


                }
                else
                {
                    MessageBox.Show("You don't have any answer!");
                }
                sqlconnection.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Answer_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            textBox3.Hide();
            label2.Hide();
            label3.Hide();
        }
    }
}
