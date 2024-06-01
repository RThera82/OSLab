using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Informations : Form
    {
        public Informations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID33 = textBox1.Text;
            string fileName = "Information.json";
            string query = "SELECT * FROM Students WHERE Id='" + ID33 + "'";
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            var dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    File.WriteAllText(fileName, "{\nname:" + dr["name"].ToString(), Encoding.UTF8);
                    File.AppendAllText(fileName, "\nlastname:" + dr["lastname"].ToString(), Encoding.UTF8);
                    File.AppendAllText(fileName, "\nusername:" + dr["username"].ToString(), Encoding.UTF8);
                    File.AppendAllText(fileName, "\npassword:" + dr["password"].ToString(), Encoding.UTF8);
                    File.AppendAllText(fileName, "\n}");
                }
                System.Diagnostics.Process.Start("Information.json");
            }
            else  
                MessageBox.Show("No information!");

            sqlConnection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
