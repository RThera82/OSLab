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
    public partial class SendMessage : Form
    {
        public SendMessage()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SendMessage_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Messages";
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            var options = command.ExecuteReader();
            while (options.Read())
            {
                comboBox1.Items.Add(options["subject"]);
            }
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID22 = textBox2.Text;
            string subject1 = comboBox1.Text;
            string body1 =textBox1.Text;
            var date1=DateTime.Now;
            string query = "INSERT INTO requests(body,date,person,subject) " +
                "VALUES('" + body1 + "','" + date1 + "','" + ID22 + "','" + subject1 + "')";
            //MessageBox.Show(query);
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int i=command.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Request send successfully!");
                this.Hide();
                //UserPannel userPannel3 = new UserPannel();
                //userPannel3.Show();
            }
            else
            {
                MessageBox.Show("Nashod");
            }
            sqlConnection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
